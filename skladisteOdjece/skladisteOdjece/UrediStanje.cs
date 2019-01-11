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
    public partial class UrediStanje : Form
    {
        private Konekcija konekcija;
        
        public UrediStanje(int odabranID,int kolicina, string pozicija, Konekcija konekcija)
        {
            InitializeComponent();

            textBoxID.Text = odabranID.ToString();
            textBoxKolicina.Text = kolicina.ToString();
            textBoxPozicija.Text = pozicija.ToString();

            this.konekcija = konekcija;
            this.konekcija.OtvoriKonekciju();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            int odabranID = int.Parse(textBoxID.Text);
            int kolicina = int.Parse(textBoxKolicina.Text);
            string pozicija = textBoxPozicija.Text;

            string sql = "UPDATE stanje_na_sk SET kolicina="+kolicina+", pozicija_u_sk='"+pozicija+"' WHERE vk_odjeca="+odabranID;
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);
            NpgsqlDataReader dataReader=command.ExecuteReader();

            this.konekcija.ZatvoriKonekciju();
            this.Close();

        }
    }
}
