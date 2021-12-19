namespace WindowsFormsApp1
{
    partial class Sotr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dolzhnost = new System.Windows.Forms.ComboBox();
            this.filial = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(657, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить значения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.perehod_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(657, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Добавить фильтр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dolzhnost
            // 
            this.dolzhnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dolzhnost.FormattingEnabled = true;
            this.dolzhnost.Location = new System.Drawing.Point(3, 3);
            this.dolzhnost.Name = "dolzhnost";
            this.dolzhnost.Size = new System.Drawing.Size(124, 21);
            this.dolzhnost.TabIndex = 3;
            this.dolzhnost.Tag = "ID_Dolzhnost";
            // 
            // filial
            // 
            this.filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filial.FormattingEnabled = true;
            this.filial.Location = new System.Drawing.Point(3, 30);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(124, 21);
            this.filial.TabIndex = 4;
            this.filial.Tag = "ID_Filial";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filial);
            this.panel1.Controls.Add(this.dolzhnost);
            this.panel1.Location = new System.Drawing.Point(657, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 55);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // Sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sotr";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox filial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dolzhnost;
    }
}