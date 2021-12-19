namespace WindowsFormsApp1
{
    partial class EditRash
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rashodi_value = new System.Windows.Forms.TextBox();
            this.rashodi_date = new System.Windows.Forms.TextBox();
            this.rashodi_name = new System.Windows.Forms.TextBox();
            this.fio = new System.Windows.Forms.ComboBox();
            this.postavshik = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tovar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(13, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Название поставщика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Значение расходов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Дата расходов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название расходов";
            // 
            // rashodi_value
            // 
            this.rashodi_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rashodi_value.Location = new System.Drawing.Point(203, 107);
            this.rashodi_value.Name = "rashodi_value";
            this.rashodi_value.Size = new System.Drawing.Size(242, 26);
            this.rashodi_value.TabIndex = 24;
            // 
            // rashodi_date
            // 
            this.rashodi_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rashodi_date.Location = new System.Drawing.Point(203, 75);
            this.rashodi_date.Name = "rashodi_date";
            this.rashodi_date.Size = new System.Drawing.Size(242, 26);
            this.rashodi_date.TabIndex = 23;
            // 
            // rashodi_name
            // 
            this.rashodi_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rashodi_name.Location = new System.Drawing.Point(204, 9);
            this.rashodi_name.Name = "rashodi_name";
            this.rashodi_name.Size = new System.Drawing.Size(242, 26);
            this.rashodi_name.TabIndex = 22;
            // 
            // fio
            // 
            this.fio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fio.FormattingEnabled = true;
            this.fio.Location = new System.Drawing.Point(204, 139);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(243, 28);
            this.fio.TabIndex = 21;
            // 
            // postavshik
            // 
            this.postavshik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.postavshik.FormattingEnabled = true;
            this.postavshik.Location = new System.Drawing.Point(204, 173);
            this.postavshik.Name = "postavshik";
            this.postavshik.Size = new System.Drawing.Size(243, 28);
            this.postavshik.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(352, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(251, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Название товара";
            // 
            // tovar
            // 
            this.tovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tovar.FormattingEnabled = true;
            this.tovar.Location = new System.Drawing.Point(204, 38);
            this.tovar.Name = "tovar";
            this.tovar.Size = new System.Drawing.Size(243, 28);
            this.tovar.TabIndex = 34;
            // 
            // EditRash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tovar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rashodi_value);
            this.Controls.Add(this.rashodi_date);
            this.Controls.Add(this.rashodi_name);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.postavshik);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditRash";
            this.Text = "EditRash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rashodi_value;
        private System.Windows.Forms.TextBox rashodi_date;
        private System.Windows.Forms.TextBox rashodi_name;
        private System.Windows.Forms.ComboBox fio;
        private System.Windows.Forms.ComboBox postavshik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tovar;
    }
}