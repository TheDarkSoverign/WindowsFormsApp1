using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        public string connect = "Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none";



        private void button1_Click(object sender, EventArgs e)
        {
            Sotr st = new Sotr();
            st.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dohodi dh = new Dohodi();
            dh.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rashodi us = new Rashodi();
            us.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filial fi = new Filial();
            fi.ShowDialog();
        }
    }
}
