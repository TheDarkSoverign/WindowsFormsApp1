namespace WindowsFormsApp1
{
    partial class EditDohodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dohod_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dohod_date = new System.Windows.Forms.TextBox();
            this.dohod_value = new System.Windows.Forms.TextBox();
            this.fio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название дохода";
            // 
            // dohod_name
            // 
            this.dohod_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dohod_name.Location = new System.Drawing.Point(199, 12);
            this.dohod_name.Name = "dohod_name";
            this.dohod_name.Size = new System.Drawing.Size(242, 26);
            this.dohod_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(245, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(346, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата дохода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значение дохода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО";
            // 
            // dohod_date
            // 
            this.dohod_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dohod_date.Location = new System.Drawing.Point(199, 44);
            this.dohod_date.Name = "dohod_date";
            this.dohod_date.Size = new System.Drawing.Size(242, 26);
            this.dohod_date.TabIndex = 8;
            // 
            // dohod_value
            // 
            this.dohod_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dohod_value.Location = new System.Drawing.Point(199, 76);
            this.dohod_value.Name = "dohod_value";
            this.dohod_value.Size = new System.Drawing.Size(242, 26);
            this.dohod_value.TabIndex = 9;
            // 
            // fio
            // 
            this.fio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fio.FormattingEnabled = true;
            this.fio.Location = new System.Drawing.Point(199, 108);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(242, 28);
            this.fio.TabIndex = 11;
            // 
            // EditDohodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 184);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.dohod_value);
            this.Controls.Add(this.dohod_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dohod_name);
            this.Controls.Add(this.label1);
            this.Name = "EditDohodi";
            this.Text = "Изменить таблицу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dohod_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dohod_date;
        private System.Windows.Forms.TextBox dohod_value;
        private System.Windows.Forms.ComboBox fio;
    }
}