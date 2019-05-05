using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private List<TextBox> textBoxList = new List<TextBox>();
        private List<CheckBox> checkBoxList = new List<CheckBox>();
        private List<string[]> users = new List<string[]>();
        private int textboxStartX = 33;
        private int textboxStartY = 69;
        private int checkboxStartX = 254;
        private int checkboxStartY = 69;
        private int coef = 0;
        private int c = 22;

        private void EditUsers_Load(object sender, EventArgs e)
        {
            // Добавлять пользователей может только админушка
            if (Program.LevelPrivelegies == "A6105C0A611B41B08F1209506350279E")
                AddNewUser.Enabled = true;
            else
                AddNewUser.Enabled = false;
            
            string[] raw_users;
            
            using (StreamReader usersFile = new StreamReader("../../USERS.txt"))
            {
                raw_users = usersFile.ReadToEnd().Split(new char[] { ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            }

            
            foreach (string user in raw_users)
            {
                if (user.Split('-').Length >= 3)
                {
                    users.Add(user.Split('-'));
                }
            }

            coef = 0;
            for (int i = 0; i < users.Count; i++)
            {
                textBoxList.Add(new TextBox());
                if (i != 0)
                {
                    textboxStartY = textBoxList[i - 1].Location.Y + c;
                }
                textBoxList[i].Location = new Point(textboxStartX, textboxStartY);
                textBoxList[i].Size = new Size(158, 20);
                textBoxList[i].Text = users[i][0];
                textBoxList[i].Enabled = false;
                textBoxList[i].Show();

                checkBoxList.Add(new CheckBox());
                if (i != 0)
                {
                    checkboxStartY = checkBoxList[i - 1].Location.Y + c;
                }
                checkBoxList[i].Location = new Point(checkboxStartX, checkboxStartY);
                checkBoxList[i].Text = "Да";
                checkBoxList[i].Size = new Size(80, 17);
                checkBoxList[i].Enabled = false;
                checkBoxList[i].Visible = true;
                if (users[i][2] == "A6105C0A611B41B08F1209506350279E")
                    checkBoxList[i].Checked = true;
                else
                    checkBoxList[i].Checked = false;
                checkBoxList[i].Show();

                textBoxLogin.Location = new Point(textBoxLogin.Location.X, textBoxLogin.Location.Y + c);
                textBoxPassword.Location = new Point(textBoxPassword.Location.X, textBoxPassword.Location.Y + c);
                AddNewUser.Location = new Point(AddNewUser.Location.X, AddNewUser.Location.Y + c);

                this.Controls.Add(textBoxList[i]);
                this.Controls.Add(checkBoxList[i]);

                coef++;
            }

            this.Update();
            this.Refresh();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != null && textBoxLogin.Text != "" &&
                textBoxPassword.Text != null && textBoxPassword.Text != "" &&
                textBoxLogin.Text.All(x => Char.IsLetter(x) || Char.IsDigit(x)))
            {
                users.Add(new string[] { textBoxLogin.Text, CalculateMD5Hash(textBoxPassword.Text), "7FA3B767C460B54A2BE4D49030B349C7" });

                int size = textBoxList.Count;
                textBoxList.Add(new TextBox());
                //var txl = textBoxList[size].Location;
                textBoxList[size].Location = new Point(textboxStartX, textBoxList[size - 1].Location.Y + c);
                textBoxList[size].Size = new Size(158, 20);
                textBoxList[size].Text = users[size][0];
                textBoxList[size].Enabled = false;
                textBoxList[size].Show();
                

                checkBoxList.Add(new CheckBox());
                checkBoxList[size].Location = new Point(checkboxStartX, checkBoxList[size - 1].Location.Y + c);
                checkBoxList[size].Text = "Да";
                checkBoxList[size].Size = new Size(80, 17);
                checkBoxList[size].Enabled = false;
                checkBoxList[size].Visible = true;
                if (users[size][2] == "A6105C0A611B41B08F1209506350279E")
                    checkBoxList[size].Checked = true;
                else
                    checkBoxList[size].Checked = false;
                checkBoxList[size].Show();


                textBoxLogin.Location = new Point(textBoxLogin.Location.X, textBoxLogin.Location.Y + c / 2);
                textBoxPassword.Location = new Point(textBoxPassword.Location.X, textBoxPassword.Location.Y + c / 2);
                AddNewUser.Location = new Point(AddNewUser.Location.X, AddNewUser.Location.Y + c / 2);

                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                this.Controls.Add(textBoxList[size]);
                this.Controls.Add(checkBoxList[size]);

                

                this.Update();
                this.Refresh();
            }
            else
            {
                MessageBox.Show(
                    "Неверно введены данные! Проверьте, логин может содержать только буквы или цифры",
                    "Создание пользователя",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
    }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter usersFile = new StreamWriter("../../USERS.txt"))
            {
                foreach (string[] user in users)
                {
                    usersFile.WriteLine($"{user[0]}-{user[1]}-{user[2]},");
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxList = new List<TextBox>();
            checkBoxList = new List<CheckBox>();
            this.Close();
        }

        private void EditUsers_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
