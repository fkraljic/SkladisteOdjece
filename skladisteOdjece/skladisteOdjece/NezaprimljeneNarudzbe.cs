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
    public partial class NezaprimljeneNarudzbe : Form
    {
        private Konekcija konekcija;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private int odabranID;

        public NezaprimljeneNarudzbe()
        {
            InitializeComponent();
            konekcija = new Konekcija();
            PrikaziPodatke();
        }

        private void PrikaziPodatke()
        {
            konekcija.OtvoriKonekciju();
            string sql = "SELECT n.id AS ID_narudzbe, o.naziv AS Naziv_odjece, n.kolicina AS Narucena_kolicina, n.datum AS Datum_narucivanja,n.vk_odjeca AS Dobava_robe " +
                "FROM narudzbenica n JOIN odjeca_velicina ov ON n.vk_odjeca=ov.id " +
                "JOIN odjeca o ON ov.vk_odjeca=o.id " +
                "JOIN dobava_robe dr ON n.vk_dobava_robe=dr.id " +
                "WHERE n.zaprimljeno IS False " +
                "ORDER BY 1;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            konekcija.ZatvoriKonekciju();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odabranID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }

        private void buttonZaprimljeno_Click(object sender, EventArgs e)
        {
            if (odabranID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Roba s narudžbe " + odabranID + " je zaprimljena!", "Zaprimljena roba", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    konekcija.OtvoriKonekciju();
                    string sql = "UPDATE narudzbenica SET zaprimljeno=" + true + " WHERE id=" + odabranID + ";";
                    NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    konekcija.ZatvoriKonekciju();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Niste nikakvu robu za zaprimanje odabrali!","Upozorenje");
            }

            PrikaziPodatke();

        }
    }
}
