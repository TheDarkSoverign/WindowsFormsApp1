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
    public partial class Sotr : Form
    {
        public Sotr()
        {
            InitializeComponent();
            qr = _qr;
            LoadTable();
            LoadCombobox();
        }

        string qr;
        const string _qr = "SELECT sotrudnik.ID_Sotrudnik, CONCAT_WS(' ', sotrudnik.Familiya, sotrudnik.Imya, sotrudnik.Otchestvo) AS `ФИО`, " +
        "sotrudnik.Birthday_Data, sotrudnik.Work_Start_Data, dolzhnost.Dolzhnost_Name, filial.Filial_Address " +
        "FROM sotrudnik, filial, dolzhnost " +
        "WHERE sotrudnik.ID_Dolzhnost = dolzhnost.ID_Dolzhnost and sotrudnik.ID_Filial = filial.ID_Filial ";
        
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
            ("SELECT * FROM filial", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            filial.DataSource = dt;
            filial.DisplayMember = "Filial_Address";
            filial.ValueMember = "ID_Filial";
            filial.SelectedIndex = -1;
            filial.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
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
            dolzhnost.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }

        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            qr = _qr;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) qr += $@" and sotrudnik.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void perehod_Click(object sender, EventArgs e)
        {
            EditSotr edst = new EditSotr();
            edst.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                EditSotr edst = new EditSotr(id);
                edst.ShowDialog();
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
            dolzhnost.SelectedIndex = -1;
            filial.SelectedIndex = -1;
        }
    }
}
