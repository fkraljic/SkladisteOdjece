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
    public partial class DodavanjeNaSkladište : Form
    {
        private Konekcija konekcija;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public DodavanjeNaSkladište()
        {
            InitializeComponent();
            konekcija = new Konekcija();

            PrikazAsortimana();
        }

        private void PrikazAsortimana()
        {
            konekcija.OtvoriKonekciju();
            string sql = "SELECT o.id AS Oznaka,ov.id AS Oznaka_velicine,o.naziv AS Naziv,o.opis AS Opis,v.naziv AS Vrsta,u.naziv AS Uzrast,vl.oznaka AS Velicina FROM odjeca o JOIN vrsta v ON o.vk_vrsta = v.id JOIN uzrast u ON o.vk_uzrast = u.id JOIN spol s ON o.vk_spol = s.spol JOIN materijal m ON o.vk_materijal = m.id JOIN odjeca_velicina ov ON ov.vk_odjeca = o.id JOIN velicina vl ON ov.vk_velicina = vl.id ORDER BY 3 ASC; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

            konekcija.OtvoriKonekciju();
        }

        private void DodavanjeNaSkladište_Leave(object sender, EventArgs e)
        {
            konekcija.ZatvoriKonekciju();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idOdjece = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int kolicina = int.Parse(textBoxKolicina.Text);
            string pozicija = "";
            pozicija = textBoxPozicija.Text;

            string sql = "INSERT INTO stanje_na_sk(vk_odjeca,kolicina,pozicija_u_sk) VALUES(" + idOdjece + "," + kolicina + ",'"+pozicija+"');";
            try
            {

                konekcija.OtvoriKonekciju();
                NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);
                command.ExecuteReader();
                konekcija.OtvoriKonekciju();
            }
            catch(PostgresException msg)
            {
                MessageBox.Show("Na skladištu postoji takva stavka!","Upozorenje!");
            }  
        }
    }
}
