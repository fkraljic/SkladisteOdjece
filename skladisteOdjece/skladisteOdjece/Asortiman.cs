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
    public partial class Asortiman : Form
    {
        Konekcija konekcija;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private int idOdjece;
        private DataGridViewRow odjeca;

        public Asortiman(Konekcija konekcija)
        {
            InitializeComponent();
            this.konekcija = konekcija;
            PrikazPodataka();
        }

        private void PrikazPodataka()
        {
            string sql = "SELECT o.id,o.naziv,o.opis,v.naziv AS Vrsta,u.naziv AS Uzrast,s.spol AS Spol,m.naziv AS Materijal,o.zemlja_proizvodnje,o.godina,o.min_kolicina,o.kolicina_narucivanja " +
                "FROM odjeca o JOIN vrsta v ON o.vk_vrsta=v.id " +
                "JOIN uzrast u ON o.vk_uzrast=u.id " +
                "JOIN spol s ON o.vk_spol=s.spol " +
                "JOIN materijal m ON o.vk_materijal=m.id " +
                "ORDER BY 1;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void buttonDodajO_Click(object sender, EventArgs e)
        {
            UnosIzmjenaAsortimana unos = new UnosIzmjenaAsortimana();
            unos.ShowDialog();

            PrikazPodataka();
        }

        private void buttonIzmjeniO_Click(object sender, EventArgs e)
        {
            UnosIzmjenaAsortimana unos = new UnosIzmjenaAsortimana(idOdjece,odjeca);
            unos.ShowDialog();

            PrikazPodataka();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idOdjece = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                odjeca = dataGridView1.CurrentRow;
            }
            catch (Exception) { }
        }
    }
}
