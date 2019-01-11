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
    public partial class ZaprimljeneNarudzbe : Form
    {
        private Konekcija konekcija;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public ZaprimljeneNarudzbe(Konekcija konekcija)
        {
            InitializeComponent();
            this.konekcija = konekcija;
            PrikaziPodatke();
        }

        private void PrikaziPodatke()
        {
            string sql = "SELECT n.id AS ID_narudzbe, o.naziv AS Naziv_odjece, n.kolicina AS Narucena_kolicina, n.datum AS Datum_narucivanja, dr.datum_zaprimanja AS Datum_zaprimanja " +
                "FROM narudzbenica n JOIN odjeca_velicina ov ON n.vk_odjeca=ov.id " +
                "JOIN odjeca o ON ov.vk_odjeca=o.id " +
                "JOIN dobava_robe dr ON n.vk_dobava_robe=dr.id " +
                "WHERE dr.datum_zaprimanja IS NOT NULL " +
                "ORDER BY 1;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
