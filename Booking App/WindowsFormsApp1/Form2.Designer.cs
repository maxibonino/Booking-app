namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Dolzhnost = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Sotrudnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(92, 51);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(136, 20);
            this.FirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(92, 79);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(136, 20);
            this.LastName.TabIndex = 1;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(92, 107);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(136, 20);
            this.Patronymic.TabIndex = 2;
            // 
            // Dolzhnost
            // 
            this.Dolzhnost.Location = new System.Drawing.Point(92, 135);
            this.Dolzhnost.Name = "Dolzhnost";
            this.Dolzhnost.Size = new System.Drawing.Size(136, 20);
            this.Dolzhnost.TabIndex = 3;
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(92, 163);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(136, 20);
            this.Telephone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон";
            // 
            // Add_Sotrudnik
            // 
            this.Add_Sotrudnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Sotrudnik.Location = new System.Drawing.Point(92, 207);
            this.Add_Sotrudnik.Name = "Add_Sotrudnik";
            this.Add_Sotrudnik.Size = new System.Drawing.Size(75, 23);
            this.Add_Sotrudnik.TabIndex = 10;
            this.Add_Sotrudnik.Text = "Добавить";
            this.Add_Sotrudnik.UseVisualStyleBackColor = true;
            this.Add_Sotrudnik.Click += new System.EventHandler(this.Add_Sotrudnik_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Add_Sotrudnik;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Add_Sotrudnik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Dolzhnost);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Dolzhnost;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Sotrudnik;
    }
}