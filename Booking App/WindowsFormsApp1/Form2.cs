using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Add_Sotrudnik_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.ConnectionString))
            {
                string query = $"INSERT INTO [Sotrudnik] (Id_sot, Lastname, Firstname, Patronymic, Dolzhnost, Telephone, Id_kompl, Id_polz) VALUES ({new Random().Next(10010,10000000)},N'{LastName.Text}', N'{FirstName.Text}', N'{Patronymic.Text}', N'{Dolzhnost.Text}', {Telephone.Text}, 3, 4)";
                try
                {
                con.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(
                            "Вставка произошла успешно",
                            "Добавление",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Что-то пошло не так...",
                            "Добавление",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch
                {
                    MessageBox.Show(
                        "Что-то пошло не так..." + query,
                        "Добавление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
