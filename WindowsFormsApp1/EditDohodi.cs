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
    public partial class EditDohodi : Form
    {
        public EditDohodi()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public EditDohodi(int _id)
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
                ("SELECT * FROM dohodi WHERE ID_Dohodi=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dohod_name.Text = dt.Rows[0][1].ToString();
            dohod_date.Text = dt.Rows[0][2].ToString();
            dohod_value.Text = dt.Rows[0][3].ToString();
        }
        public void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
            ("SELECT * FROM sotrudnik", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fio.DataSource = dt;
            fio.DisplayMember = "CONCAT_WS(' ', Familiya, Imya, Otchestvo) AS `ФИО`";
            fio.ValueMember = "ID_Sotrudnik";
            fio.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"INSERT INTO dohodi (Dohod_Name, Dohod_Date, Dohod_Value, ID_Sotrudnik) 
                values ('{dohod_name.Text}',
                '{dohod_date.Text}', 
                '{dohod_value.Text}',
                {fio.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"UPDATE dohodi SET 
                Dohod_Name='{dohod_name.Text}',
                Dohod_Date='{dohod_date.Text}',
                Dohod_Value='{dohod_value.Text}',
                ID_Sotrudnik='{fio.SelectedValue}'
                WHERE ID_Dohodi={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"DELETE FROM dohodi WHERE ID_Dohodi={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}