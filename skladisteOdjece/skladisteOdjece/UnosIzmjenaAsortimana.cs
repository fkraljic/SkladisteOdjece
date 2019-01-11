using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skladisteOdjece
{
    public partial class UnosIzmjenaAsortimana : Form
    {
        private Konekcija konekcija;
        private bool izmjena = false;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();


        public UnosIzmjenaAsortimana()
        {
            InitializeComponent();
            konekcija = new Konekcija();
            konekcija.OtvoriKonekciju();

            PuniCombobox();
        }

        private void PuniCombobox()
        {
            string sqlVrsta = "SELECT id,naziv FROM vrsta;";
            NpgsqlDataAdapter daVrsta = new NpgsqlDataAdapter(sqlVrsta, konekcija.conn);

            daVrsta.Fill(ds);
            dt = ds.Tables[0];

            VadiElementeVanIzDataSeta(dt, comboBoxVrsta);

        }

        private void VadiElementeVanIzDataSeta(DataTable dataTable, ComboBox c)
        {
            dt = dataTable;
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {

                    c.Items.Add(row[1].ToString());
                }
            }
        }

        private void Unesi()
        {
            string naziv = textBoxNaziv.Text;
            string opis = textBoxOpis.Text;
            int vrsta = int.Parse(comboBoxVrsta.SelectedIndex.ToString());
            int uzrast = int.Parse(comboBoxUzrast.SelectedIndex.ToString());
            int spol = int.Parse(comboBoxSpol.SelectedIndex.ToString());
            int materijal = int.Parse(comboBoxMaterijal.SelectedIndex.ToString());
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            this.Text=comboBoxVrsta.SelectedIndex.ToString();
        }
    }
}
