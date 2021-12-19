using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class EditFilial : Form
    {
        public EditFilial()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public EditFilial(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            id = _id;
            LoadString();
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }
        private void LoadString()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("SELECT * FROM filial WHERE ID_Filial=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            filial_address.Text = dt.Rows[0][1].ToString();
        }
        public void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
            ("SELECT * FROM sklad", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sklad.DataSource = dt;
            sklad.DisplayMember = "Sklad_address";
            sklad.ValueMember = "ID_Sklad";
            sklad.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"INSERT INTO filial (Filial_Address, ID_Sklad) 
                values ('{filial_address.Text}',
                {sklad.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"UPDATE filial SET 
                Familiya='{filial_address.Text}',
                ID_Sklad='{sklad.SelectedValue}'
                WHERE ID_Filial={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"DELETE FROM filial WHERE ID_Filial={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }


    }
}