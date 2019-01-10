using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace skladisteOdjece
{
    public partial class StanjeSkladišta : Form
    {
        private Konekcija konekcija;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public StanjeSkladišta(Konekcija konekcija)
        {
            InitializeComponent();
            this.konekcija = konekcija;
            PrikazStanjaSkladista();
        }

        private void PrikazStanjaSkladista()
        {
            string sql = "SELECT o.id AS Oznaka,ov.id AS Oznaka_velicine,o.naziv AS Naziv,o.opis AS Opis,v.naziv AS Vrsta,u.naziv AS Uzrast,s.spol AS Spol,m.naziv AS Materijal,vl.oznaka AS Velicina,sns.kolicina AS Kolicina,sns.pozicija_u_sk AS Lokacija FROM odjeca o JOIN vrsta v ON o.vk_vrsta = v.id JOIN uzrast u ON o.vk_uzrast = u.id JOIN spol s ON o.vk_spol = s.spol JOIN materijal m ON o.vk_materijal = m.id JOIN odjeca_velicina ov ON ov.vk_odjeca = o.id JOIN velicina vl ON ov.vk_velicina = vl.id JOIN stanje_na_sk sns ON sns.vk_odjeca = ov.id ORDER BY 3,8 ASC; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

    }
}
