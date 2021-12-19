namespace WindowsFormsApp1
{
    partial class EditSotr
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filial = new System.Windows.Forms.ComboBox();
            this.dolzhnost = new System.Windows.Forms.ComboBox();
            this.familiya = new System.Windows.Forms.TextBox();
            this.imya = new System.Windows.Forms.TextBox();
            this.otchestvo = new System.Windows.Forms.TextBox();
            this.birthdaydata = new System.Windows.Forms.TextBox();
            this.work_start_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(250, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(351, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filial
            // 
            this.filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filial.FormattingEnabled = true;
            this.filial.Location = new System.Drawing.Point(203, 203);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(243, 28);
            this.filial.TabIndex = 3;
            // 
            // dolzhnost
            // 
            this.dolzhnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dolzhnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dolzhnost.FormattingEnabled = true;
            this.dolzhnost.Location = new System.Drawing.Point(203, 169);
            this.dolzhnost.Name = "dolzhnost";
            this.dolzhnost.Size = new System.Drawing.Size(243, 28);
            this.dolzhnost.TabIndex = 4;
            // 
            // familiya
            // 
            this.familiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.familiya.Location = new System.Drawing.Point(204, 9);
            this.familiya.Name = "familiya";
            this.familiya.Size = new System.Drawing.Size(242, 26);
            this.familiya.TabIndex = 5;
            // 
            // imya
            // 
            this.imya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.imya.Location = new System.Drawing.Point(204, 41);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(242, 26);
            this.imya.TabIndex = 6;
            // 
            // otchestvo
            // 
            this.otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.otchestvo.Location = new System.Drawing.Point(204, 73);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(242, 26);
            this.otchestvo.TabIndex = 7;
            // 
            // birthdaydata
            // 
            this.birthdaydata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birthdaydata.Location = new System.Drawing.Point(204, 105);
            this.birthdaydata.Name = "birthdaydata";
            this.birthdaydata.Size = new System.Drawing.Size(242, 26);
            this.birthdaydata.TabIndex = 8;
            // 
            // work_start_data
            // 
            this.work_start_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.work_start_data.Location = new System.Drawing.Point(204, 137);
            this.work_start_data.Name = "work_start_data";
            this.work_start_data.Size = new System.Drawing.Size(242, 26);
            this.work_start_data.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рожения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата приема на работу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Адрес филиала";
            // 
            // EditSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 289);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.work_start_data);
            this.Controls.Add(this.birthdaydata);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.imya);
            this.Controls.Add(this.familiya);
            this.Controls.Add(this.dolzhnost);
            this.Controls.Add(this.filial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditSotr";
            this.Text = "Изменить таблицу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox filial;
        private System.Windows.Forms.ComboBox dolzhnost;
        private System.Windows.Forms.TextBox familiya;
        private System.Windows.Forms.TextBox imya;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.TextBox birthdaydata;
        private System.Windows.Forms.TextBox work_start_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}