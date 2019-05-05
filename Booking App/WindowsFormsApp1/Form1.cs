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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void редактироватьПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form edit = new EditUsers();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Broni]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Broni]");

            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Load_Sotrudniki_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Sotrudnik]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Sotrudnik]");

            SotrudnikiDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Add_Man_Click(object sender, EventArgs e)
        {
            var AddingForm = new Form2();
            if (Program.LevelPrivelegies == "A6105C0A611B41B08F1209506350279E")
            {
                AddingForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Недостаточно прав!",
                    "Проверка привелегий",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void DeleteSotrudnika_Click(object sender, EventArgs e)
        {
            var t = SotrudnikiDG.SelectedRows;
            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Sotrudnik] WHERE Id_sot = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Что-то пошло не так..." + query,
                            "Удаление",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                SotrudnikiDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            SotrudnikiDG.Update();
            SotrudnikiDG.Refresh();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ждите обновлений программы в следующих версиях!\nТекущая версия 1.0",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LoadPolzovateli_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Polzovatel]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Polzovatel]");

            PolzovateliDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Go to:\nStackoverflow\nCyberforum",
                "Помощь",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        //Персональные условия
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Personal_uslov]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Personal_uslov]");

            PersUslDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void LoadOplata_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Oplata]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Oplata]");

            OplataDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void LoadKvartira_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Kvartira]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Kvartira]");

            KvartiraDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            var t = PolzovateliDG.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Polzovatel] WHERE Id_polz = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                PolzovateliDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            PolzovateliDG.Update();
            PolzovateliDG.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var t = PersUslDG.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Personal_uslov] WHERE Id_usl = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                PersUslDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            PersUslDG.Update();
            PersUslDG.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var t = OplataDG.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Oplata] WHERE Id_opl = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                OplataDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            OplataDG.Update();
            OplataDG.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var t = KvartiraDG.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Kvartira] WHERE Id_kv = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                KvartiraDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            KvartiraDG.Update();
            KvartiraDG.Refresh();
        }

        private void LoadClient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.ConnectionString);
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Klient]", con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Klient]");

            ClientDG.DataSource = ds.Tables[0];

            con.Close();
        }

        private void DeleteClients_Click(object sender, EventArgs e)
        {
            var t = ClientDG.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Klient] WHERE Id_kl = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                ClientDG.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            ClientDG.Update();
            ClientDG.Refresh();
        }

        private void DeleteBooking_Click(object sender, EventArgs e)
        {
            var t = dataGridView1.SelectedRows;

            for (int i = 0; i < t.Count; i++)
            {
                using (SqlConnection con = new SqlConnection(Program.ConnectionString))
                {
                    string query = $"DELETE FROM [Broni] WHERE Id_bron = {t[i].Cells[0].Value}";
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, con);


                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(
                                $"Удаление произошло успешно - {t[i].Cells[1].Value}",
                                $"Удаление - {t[i].Cells[1].Value}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Что-то пошло не так...",
                                "Удаление",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch
                    {
                    }
                }

                dataGridView1.Rows.RemoveAt(t[i].Cells[0].RowIndex);
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
