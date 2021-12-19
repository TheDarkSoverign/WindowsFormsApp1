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
    public partial class EditSotr : Form
    {
        public EditSotr()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public EditSotr(int _id)
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
                ("SELECT * FROM sotrudnik WHERE ID_Sotrudnik=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            familiya.Text = dt.Rows[0][1].ToString();
            imya.Text = dt.Rows[0][2].ToString();
            otchestvo.Text = dt.Rows[0][3].ToString();
            birthdaydata.Text = dt.Rows[0][4].ToString();
            work_start_data.Text = dt.Rows[0][5].ToString();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
            ("SELECT * FROM filial", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            filial.DataSource = dt;
            filial.DisplayMember = "Filial_Address";
            filial.ValueMember = "ID_Filial";
            filial.SelectedIndex = -1;
            MySqlConnection con1 = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
            ("SELECT * FROM dolzhnost", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dolzhnost.DataSource = dt1;
            dolzhnost.DisplayMember = "Dolzhnost_Name";
            dolzhnost.ValueMember = "ID_Dolzhnost";
            dolzhnost.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"INSERT INTO sotrudnik (Familiya, Imya, Otchestvo, Birthday_Data, Work_Start_Data, ID_Dolzhnost, ID_Filial) 
                values ('{familiya.Text}',
                '{imya.Text}', 
                '{otchestvo.Text}',
                '{birthdaydata.Text}',
                '{work_start_data.Text}',
                {dolzhnost.SelectedValue},
                {filial.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"UPDATE sotrudnik SET 
                Familiya='{familiya.Text}',
                Imya='{imya.Text}',
                Otchestvo='{otchestvo.Text}',
                Birthday_Data='{birthdaydata.Text}',
                Work_Start_Data='{work_start_data.Text}',
                ID_Dolzhnost='{dolzhnost.SelectedValue}',
                ID_Filial='{filial.SelectedValue}'
                WHERE ID_Sotrudnik={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
               ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd='' ;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"DELETE FROM sotrudnik WHERE ID_Sotrudnik={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
