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
    public partial class Filial : Form
    {
        public Filial()
        {
            InitializeComponent();
            qr = _qr;
            LoadTable();
            LoadCombobox();
        }
        string qr;
        const string _qr = "SELECT filial.ID_Filial, filial.Filial_Address, sklad.Sklad_address " +
            "FROM filial, sklad " +
            "WHERE filial.ID_Sklad = sklad.ID_Sklad ";


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
            ("SELECT * FROM sklad", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sklad.DataSource = dt;
            sklad.DisplayMember = "Sklad_address";
            sklad.ValueMember = "ID_Sklad";
            sklad.SelectedIndex = -1;
            sklad.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }

        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            qr = _qr;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) qr += $@" and filial.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }
        private void perehod_Click(object sender, EventArgs e)
        {
            EditFilial edfl = new EditFilial();
            edfl.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                EditFilial edfl = new EditFilial(id);
                edfl.ShowDialog();
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
            sklad.SelectedIndex = -1;
        }
    }
}