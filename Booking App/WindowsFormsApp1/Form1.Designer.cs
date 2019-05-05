namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SotrudnikiDG = new System.Windows.Forms.DataGridView();
            this.Load_Sotrudniki = new System.Windows.Forms.Button();
            this.Add_Man = new System.Windows.Forms.Button();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSotrudnika = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PolzovateliDG = new System.Windows.Forms.DataGridView();
            this.LoadPolzovateli = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadOplata = new System.Windows.Forms.Button();
            this.LoadKvartira = new System.Windows.Forms.Button();
            this.PersUslDG = new System.Windows.Forms.DataGridView();
            this.OplataDG = new System.Windows.Forms.DataGridView();
            this.KvartiraDG = new System.Windows.Forms.DataGridView();
            this.DeleteUsers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Klient = new System.Windows.Forms.TabPage();
            this.ClientDG = new System.Windows.Forms.DataGridView();
            this.LoadClient = new System.Windows.Forms.Button();
            this.DeleteClients = new System.Windows.Forms.Button();
            this.DeleteBooking = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrudnikiDG)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolzovateliDG)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersUslDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OplataDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KvartiraDG)).BeginInit();
            this.Klient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПользователейToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // редактироватьПользователейToolStripMenuItem
            // 
            this.редактироватьПользователейToolStripMenuItem.Name = "редактироватьПользователейToolStripMenuItem";
            this.редактироватьПользователейToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.редактироватьПользователейToolStripMenuItem.Text = "Редактировать пользователей";
            this.редактироватьПользователейToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПользователейToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.Klient);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 325);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteBooking);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Брони";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteSotrudnika);
            this.tabPage2.Controls.Add(this.Add_Man);
            this.tabPage2.Controls.Add(this.Load_Sotrudniki);
            this.tabPage2.Controls.Add(this.SotrudnikiDG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(511, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SotrudnikiDG
            // 
            this.SotrudnikiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SotrudnikiDG.Location = new System.Drawing.Point(-4, 0);
            this.SotrudnikiDG.Name = "SotrudnikiDG";
            this.SotrudnikiDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SotrudnikiDG.Size = new System.Drawing.Size(511, 303);
            this.SotrudnikiDG.TabIndex = 0;
            // 
            // Load_Sotrudniki
            // 
            this.Load_Sotrudniki.Location = new System.Drawing.Point(556, 33);
            this.Load_Sotrudniki.Name = "Load_Sotrudniki";
            this.Load_Sotrudniki.Size = new System.Drawing.Size(75, 23);
            this.Load_Sotrudniki.TabIndex = 1;
            this.Load_Sotrudniki.Text = "Загрузить";
            this.Load_Sotrudniki.UseVisualStyleBackColor = true;
            this.Load_Sotrudniki.Click += new System.EventHandler(this.Load_Sotrudniki_Click);
            // 
            // Add_Man
            // 
            this.Add_Man.Location = new System.Drawing.Point(528, 77);
            this.Add_Man.Name = "Add_Man";
            this.Add_Man.Size = new System.Drawing.Size(140, 23);
            this.Add_Man.TabIndex = 2;
            this.Add_Man.Text = "Добавить сотрудника";
            this.Add_Man.UseVisualStyleBackColor = true;
            this.Add_Man.Click += new System.EventHandler(this.Add_Man_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            this.помощьToolStripMenuItem1.Click += new System.EventHandler(this.помощьToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // DeleteSotrudnika
            // 
            this.DeleteSotrudnika.Location = new System.Drawing.Point(528, 106);
            this.DeleteSotrudnika.Name = "DeleteSotrudnika";
            this.DeleteSotrudnika.Size = new System.Drawing.Size(140, 23);
            this.DeleteSotrudnika.TabIndex = 3;
            this.DeleteSotrudnika.Text = "Удалить записи";
            this.DeleteSotrudnika.UseVisualStyleBackColor = true;
            this.DeleteSotrudnika.Click += new System.EventHandler(this.DeleteSotrudnika_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteUsers);
            this.tabPage3.Controls.Add(this.LoadPolzovateli);
            this.tabPage3.Controls.Add(this.PolzovateliDG);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 299);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PolzovateliDG
            // 
            this.PolzovateliDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PolzovateliDG.Location = new System.Drawing.Point(-4, 0);
            this.PolzovateliDG.Name = "PolzovateliDG";
            this.PolzovateliDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PolzovateliDG.Size = new System.Drawing.Size(511, 303);
            this.PolzovateliDG.TabIndex = 0;
            // 
            // LoadPolzovateli
            // 
            this.LoadPolzovateli.Location = new System.Drawing.Point(556, 33);
            this.LoadPolzovateli.Name = "LoadPolzovateli";
            this.LoadPolzovateli.Size = new System.Drawing.Size(75, 23);
            this.LoadPolzovateli.TabIndex = 1;
            this.LoadPolzovateli.Text = "Загрузить";
            this.LoadPolzovateli.UseVisualStyleBackColor = true;
            this.LoadPolzovateli.Click += new System.EventHandler(this.LoadPolzovateli_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.PersUslDG);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(676, 299);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Персональные условия";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.OplataDG);
            this.tabPage5.Controls.Add(this.LoadOplata);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(676, 299);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Оплата";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.KvartiraDG);
            this.tabPage6.Controls.Add(this.LoadKvartira);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(676, 299);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Квартира";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadOplata
            // 
            this.LoadOplata.Location = new System.Drawing.Point(556, 33);
            this.LoadOplata.Name = "LoadOplata";
            this.LoadOplata.Size = new System.Drawing.Size(75, 23);
            this.LoadOplata.TabIndex = 0;
            this.LoadOplata.Text = "Загрузить";
            this.LoadOplata.UseVisualStyleBackColor = true;
            this.LoadOplata.Click += new System.EventHandler(this.LoadOplata_Click);
            // 
            // LoadKvartira
            // 
            this.LoadKvartira.Location = new System.Drawing.Point(556, 33);
            this.LoadKvartira.Name = "LoadKvartira";
            this.LoadKvartira.Size = new System.Drawing.Size(75, 23);
            this.LoadKvartira.TabIndex = 0;
            this.LoadKvartira.Text = "Загрузить";
            this.LoadKvartira.UseVisualStyleBackColor = true;
            this.LoadKvartira.Click += new System.EventHandler(this.LoadKvartira_Click);
            // 
            // PersUslDG
            // 
            this.PersUslDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersUslDG.Location = new System.Drawing.Point(-4, 0);
            this.PersUslDG.Name = "PersUslDG";
            this.PersUslDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersUslDG.Size = new System.Drawing.Size(511, 303);
            this.PersUslDG.TabIndex = 1;
            // 
            // OplataDG
            // 
            this.OplataDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OplataDG.Location = new System.Drawing.Point(0, 0);
            this.OplataDG.Name = "OplataDG";
            this.OplataDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OplataDG.Size = new System.Drawing.Size(511, 303);
            this.OplataDG.TabIndex = 1;
            // 
            // KvartiraDG
            // 
            this.KvartiraDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KvartiraDG.Location = new System.Drawing.Point(0, 0);
            this.KvartiraDG.Name = "KvartiraDG";
            this.KvartiraDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KvartiraDG.Size = new System.Drawing.Size(511, 303);
            this.KvartiraDG.TabIndex = 1;
            // 
            // DeleteUsers
            // 
            this.DeleteUsers.Location = new System.Drawing.Point(525, 82);
            this.DeleteUsers.Name = "DeleteUsers";
            this.DeleteUsers.Size = new System.Drawing.Size(140, 23);
            this.DeleteUsers.TabIndex = 2;
            this.DeleteUsers.Text = "Удалить записи";
            this.DeleteUsers.UseVisualStyleBackColor = true;
            this.DeleteUsers.Click += new System.EventHandler(this.DeleteUsers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить записи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Удалить записи";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(525, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Удалить записи";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Klient
            // 
            this.Klient.Controls.Add(this.DeleteClients);
            this.Klient.Controls.Add(this.LoadClient);
            this.Klient.Controls.Add(this.ClientDG);
            this.Klient.Location = new System.Drawing.Point(4, 22);
            this.Klient.Name = "Klient";
            this.Klient.Size = new System.Drawing.Size(676, 299);
            this.Klient.TabIndex = 6;
            this.Klient.Text = "Клиент";
            this.Klient.UseVisualStyleBackColor = true;
            // 
            // ClientDG
            // 
            this.ClientDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDG.Location = new System.Drawing.Point(0, 0);
            this.ClientDG.Name = "ClientDG";
            this.ClientDG.Size = new System.Drawing.Size(511, 303);
            this.ClientDG.TabIndex = 0;
            // 
            // LoadClient
            // 
            this.LoadClient.Location = new System.Drawing.Point(556, 33);
            this.LoadClient.Name = "LoadClient";
            this.LoadClient.Size = new System.Drawing.Size(75, 23);
            this.LoadClient.TabIndex = 1;
            this.LoadClient.Text = "Загрузить";
            this.LoadClient.UseVisualStyleBackColor = true;
            this.LoadClient.Click += new System.EventHandler(this.LoadClient_Click);
            // 
            // DeleteClients
            // 
            this.DeleteClients.Location = new System.Drawing.Point(525, 82);
            this.DeleteClients.Name = "DeleteClients";
            this.DeleteClients.Size = new System.Drawing.Size(140, 23);
            this.DeleteClients.TabIndex = 2;
            this.DeleteClients.Text = "Удалить записи";
            this.DeleteClients.UseVisualStyleBackColor = true;
            this.DeleteClients.Click += new System.EventHandler(this.DeleteClients_Click);
            // 
            // DeleteBooking
            // 
            this.DeleteBooking.Location = new System.Drawing.Point(547, 62);
            this.DeleteBooking.Name = "DeleteBooking";
            this.DeleteBooking.Size = new System.Drawing.Size(98, 23);
            this.DeleteBooking.TabIndex = 3;
            this.DeleteBooking.Text = "Снять бронь";
            this.DeleteBooking.UseVisualStyleBackColor = true;
            this.DeleteBooking.Click += new System.EventHandler(this.DeleteBooking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 354);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrudnikiDG)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PolzovateliDG)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersUslDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OplataDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KvartiraDG)).EndInit();
            this.Klient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПользователейToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Load_Sotrudniki;
        private System.Windows.Forms.DataGridView SotrudnikiDG;
        private System.Windows.Forms.Button Add_Man;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button DeleteSotrudnika;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LoadPolzovateli;
        private System.Windows.Forms.DataGridView PolzovateliDG;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView PersUslDG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView OplataDG;
        private System.Windows.Forms.Button LoadOplata;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView KvartiraDG;
        private System.Windows.Forms.Button LoadKvartira;
        private System.Windows.Forms.Button DeleteUsers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage Klient;
        private System.Windows.Forms.Button LoadClient;
        private System.Windows.Forms.DataGridView ClientDG;
        private System.Windows.Forms.Button DeleteClients;
        private System.Windows.Forms.Button DeleteBooking;
    }
}

