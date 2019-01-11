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
    public partial class EvidencijaSkladista : Form
    {
        private Konekcija konekcija;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public EvidencijaSkladista(Konekcija konekcija)
        {
            InitializeComponent();
            this.konekcija = konekcija;

            PrikazPodatakaEvidencije();
        }

        private void PrikazPodatakaEvidencije()
        {
            string sql = "SELECT e.id AS Evidencija_ID,o.id AS Odjeca_ID,ov.id AS Velicina_ID,o.naziv AS Naziv,v.oznaka AS Velicina,e.datum_evidencije AS Datum,e.stara_kolicina AS Stara_kolicina,e.nova_kolicina AS Nova_kolicina, e.vrsta_posla AS Vrsta FROM " +
                "evidencija_sk e JOIN odjeca_velicina ov ON e.vk_odjeca=ov.id " +
                "JOIN odjeca o ON ov.vk_odjeca=o.id " +
                "JOIN velicina v ON v.id=ov.vk_velicina " +
                "ORDER BY 6 ASC;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
