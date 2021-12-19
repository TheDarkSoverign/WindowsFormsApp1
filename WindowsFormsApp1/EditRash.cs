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
    public partial class EditRash : Form
    {
        public EditRash()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public EditRash(int _id)
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
                ("SELECT * FROM rashodi WHERE ID_Rashodi=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rashodi_name.Text = dt.Rows[0][1].ToString();
            rashodi_date.Text = dt.Rows[0][2].ToString();
            rashodi_value.Text = dt.Rows[0][3].ToString();
        }
        private void LoadCombobox()
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
            MySqlConnection con1 = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
            ("SELECT * FROM postavshik", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            postavshik.DataSource = dt1;
            postavshik.DisplayMember = "Postavshik_Name";
            postavshik.ValueMember = "ID_Postavshik";
            postavshik.SelectedIndex = -1;
            MySqlConnection con2 = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da2 = new MySqlDataAdapter
            ("SELECT * FROM tovar", con1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            tovar.DataSource = dt2;
            tovar.DisplayMember = "Tovar_Name";
            tovar.ValueMember = "ID_Tovar";
            tovar.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"INSERT INTO rashodi (Rashodi_Name, ID_Tovar Rashodi_Date, Rashodi_Value, ID_Sotrudnik, ID_Postavshik) 
                values ('{rashodi_name.Text}',
                {tovar.SelectedValue},
                '{rashodi_date.Text}', 
                '{rashodi_value.Text}',
                {fio.SelectedValue},
                {postavshik.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"UPDATE rashodi SET 
                Rashodi_Name='{rashodi_name.Text}',
                ID_Tovar='{tovar.SelectedValue}',
                Rashodi_Date='{rashodi_date.Text}',
                Rashodi_Value='{rashodi_value.Text}',
                ID_Sotrudnik='{fio.SelectedValue}',
                ID_Postavshik='{postavshik.SelectedValue}'
                WHERE ID_Rashodi={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"DELETE FROM rashodi WHERE ID_Rashodi={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}