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
    public partial class Dohodi : Form
    {
        public Dohodi()
        {
            InitializeComponent();
            qr = _qr;
            LoadTable();
            LoadCombobox();
        }
        string qr;
        const string _qr = "SELECT dohodi.ID_Dohodi, dohodi.Dohod_Name, dohodi.Dohod_Date, dohodi.Dohod_Value, CONCAT_WS(' ', sotrudnik.Familiya, sotrudnik.Imya, sotrudnik.Otchestvo) AS `ФИО` " +
            "FROM dohodi, sotrudnik " +
            "WHERE dohodi.ID_Sotrudnik = sotrudnik.ID_Sotrudnik ";


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
        }

        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            qr = _qr;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) qr += $@" and dohodi.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }
        private void perehod_Click(object sender, EventArgs e)
        {
            EditDohodi edtv = new EditDohodi();
            edtv.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                EditDohodi edtv = new EditDohodi(id);
                edtv.ShowDialog();
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
        }
    }
}