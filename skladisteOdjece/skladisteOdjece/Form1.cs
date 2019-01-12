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
    public partial class Izbornik : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public Konekcija konekcija;
        public Izbornik()
        {
            InitializeComponent();            
            konekcija = new Konekcija();
            konekcija.OtvoriKonekciju();
        }        

        private void buttonStanjeSkladista_Click(object sender, EventArgs e)
        {
            StanjeSkladišta stanjeSkladišta = new StanjeSkladišta(konekcija);
            stanjeSkladišta.ShowDialog();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEvidencija_Click(object sender, EventArgs e)
        {
            EvidencijaSkladista evidencijaSkladista = new EvidencijaSkladista(konekcija);
            evidencijaSkladista.ShowDialog();
        }

        private void buttonZaprimljeneN_Click(object sender, EventArgs e)
        {
            ZaprimljeneNarudzbe zaprimljeneNarudzbe = new ZaprimljeneNarudzbe(konekcija);
            zaprimljeneNarudzbe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NezaprimljeneNarudzbe nezaprimljeneNarudzbe = new NezaprimljeneNarudzbe();
            nezaprimljeneNarudzbe.ShowDialog();
        }

        private void buttonAsortiman_Click(object sender, EventArgs e)
        {
            Asortiman asortiman = new Asortiman(konekcija);
            asortiman.ShowDialog();
        }

        private void buttonVelicine_Click(object sender, EventArgs e)
        {
            DostupneVelicineOdjece dostupneVelicine = new DostupneVelicineOdjece(konekcija);
            dostupneVelicine.ShowDialog();
        }

        private void buttonDodavanjeNaSkl_Click(object sender, EventArgs e)
        {
            DodavanjeNaSkladište dodavanje = new DodavanjeNaSkladište();
            dodavanje.ShowDialog();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            Statistika statistika = new Statistika();
            statistika.ShowDialog();
        }

        private void Izbornik_Leave(object sender, EventArgs e)
        {
            konekcija.ZatvoriKonekciju();
        }
    }
}
