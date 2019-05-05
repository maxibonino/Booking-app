using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private bool CheckLoginPwd(List<string> logins, List<string> hashes, string login, string password)
        {
            login = login.ToLower();

            int userIndex = logins.IndexOf(login);

            return userIndex != -1 && hashes[userIndex] == CalculateMD5Hash(password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> logins;
            List<string> hashes;
            List<string> privelegies;

            using (StreamReader usersFile = new StreamReader("../../USERS.txt"))
            {
                string[] users = usersFile.ReadToEnd().Split(new char[]{ ',', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

                logins = new List<string>();
                hashes = new List<string>();
                privelegies = new List<string>();

                foreach (string user in users)
                {
                    string[] lhp = user.Split('-');
                    if (lhp.Length >= 3)
                    {
                        logins.Add(lhp[0]);
                        hashes.Add(lhp[1]);
                        privelegies.Add(lhp[2]);
                    }
                }
            }

            if (CheckLoginPwd(logins, hashes, textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show(
                    "Вход произведён успешно!",
                    "Вход",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                int userIndex = logins.IndexOf(textBoxLogin.Text.ToLower());
                if (userIndex != -1)
                    Program.LevelPrivelegies = privelegies[userIndex];

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Ошибка ввода логин-пароля!",
                    "Вход",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }
}
