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
    public partial class Rashodi : Form
    {
        public Rashodi()
        {
            InitializeComponent();
            qr = _qr;
            LoadTable();
            LoadCombobox();
        }

        string qr;
        const string _qr = "SELECT rashodi.ID_Rashodi, rashodi.Rashodi_Name, tovar.Tovar_Name, rashodi.Rashodi_Date, rashodi.Rashodi_Value, CONCAT_WS(' ', sotrudnik.Familiya, sotrudnik.Imya, sotrudnik.Otchestvo) AS `ФИО`, postavshik.Postavshik_Name " +
            "FROM rashodi, sotrudnik, postavshik, tovar " +
            "WHERE rashodi.ID_Sotrudnik = sotrudnik.ID_Sotrudnik and rashodi.ID_Postavshik = postavshik.ID_Postavshik and rashodi.ID_Tovar = tovar.ID_Tovar";

        public void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=timchuk;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
            (qr, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
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
            fio.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
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
            postavshik.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
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
            tovar.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }

        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            qr = _qr;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) qr += $@" and rashodi.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void perehod_Click(object sender, EventArgs e)
        {
            EditRash edst = new EditRash();
            edst.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                EditRash edra = new EditRash(id);
                edra.ShowDialog();
                LoadTable();
            }
            catch (InvalidCastException)
            {
                perehod_Click(null, null);
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
            fio.SelectedIndex = -1;
            postavshik.SelectedIndex = -1;
            tovar.SelectedIndex = -1;
        }
    }
}