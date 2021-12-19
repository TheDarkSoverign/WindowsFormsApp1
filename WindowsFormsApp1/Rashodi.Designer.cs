namespace WindowsFormsApp1
{
    partial class Rashodi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.postavshik = new System.Windows.Forms.ComboBox();
            this.fio = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tovar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tovar);
            this.panel1.Controls.Add(this.postavshik);
            this.panel1.Controls.Add(this.fio);
            this.panel1.Location = new System.Drawing.Point(651, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 80);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // postavshik
            // 
            this.postavshik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postavshik.FormattingEnabled = true;
            this.postavshik.Location = new System.Drawing.Point(3, 30);
            this.postavshik.Name = "postavshik";
            this.postavshik.Size = new System.Drawing.Size(124, 21);
            this.postavshik.TabIndex = 4;
            this.postavshik.Tag = "ID_Postavshik";
            // 
            // fio
            // 
            this.fio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fio.FormattingEnabled = true;
            this.fio.Location = new System.Drawing.Point(3, 3);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(124, 21);
            this.fio.TabIndex = 3;
            this.fio.Tag = "ID_Sotrudnik";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(651, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Добавить фильтр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(651, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить значения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.perehod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tovar
            // 
            this.tovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovar.FormattingEnabled = true;
            this.tovar.Location = new System.Drawing.Point(3, 56);
            this.tovar.Name = "tovar";
            this.tovar.Size = new System.Drawing.Size(124, 21);
            this.tovar.TabIndex = 5;
            this.tovar.Tag = "ID_Postavshik";
            // 
            // Rashodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rashodi";
            this.Text = "Rashodi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox postavshik;
        private System.Windows.Forms.ComboBox fio;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tovar;
    }
}