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
    public partial class DostupneVelicineOdjece : Form
    {
        private Konekcija konekcija;
        private Konekcija konekcijaSpremanja;

        private DataSet dsOdj = new DataSet();
        private DataTable dtOdj = new DataTable();

        private DataSet dsVel = new DataSet();
        private DataTable dtVel = new DataTable();

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private int idOdjece;

        public DostupneVelicineOdjece(Konekcija konekcija)
        {
            InitializeComponent();

            this.konekcija = konekcija;
            konekcijaSpremanja = new Konekcija();
            konekcijaSpremanja.OtvoriKonekciju();

            PrikazPodatakaAsortimana();
            PrikazPodatakaVelicine();
        }

        private void PrikazPodatakaAsortimana()
        {
            string sql = "SELECT o.id,o.naziv,o.opis,v.naziv AS Vrsta,u.naziv AS Uzrast,s.spol AS Spol,m.naziv AS Materijal,o.zemlja_proizvodnje,o.godina,o.min_kolicina,o.kolicina_narucivanja " +
                "FROM odjeca o JOIN vrsta v ON o.vk_vrsta=v.id " +
                "JOIN uzrast u ON o.vk_uzrast=u.id " +
                "JOIN spol s ON o.vk_spol=s.spol " +
                "JOIN materijal m ON o.vk_materijal=m.id " +
                "ORDER BY 1;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            dsOdj.Reset();
            da.Fill(dsOdj);
            dtOdj = dsOdj.Tables[0];
            dataGridViewOdjeca.DataSource = dtOdj;
        }

        private void PrikazPodatakaVelicine()
        {
            string sql = "SELECT * FROM velicina;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            dsVel.Reset();
            da.Fill(dsVel);
            dtVel = dsVel.Tables[0];
            dataGridViewVelicine.DataSource = dtVel;
        }

        private void PrikazPodatakaVelicineOdjece()
        {
            string sql = "SELECT vo.id,o.naziv,v.oznaka FROM odjeca_velicina vo " +
                "JOIN odjeca o ON vo.vk_odjeca=o.id " +
                "JOIN velicina v ON vo.vk_velicina=v.id " +
                "WHERE vo.vk_odjeca="+idOdjece+";";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewVelicineOdjece.DataSource = dt;
        }

        private void dataGridViewOdjeca_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idOdjece = int.Parse(dataGridViewOdjeca.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }

            PrikazPodatakaVelicineOdjece();
        }

        private void SpremiVelicinuOdjece()
        {
            int odjeca = int.Parse(dataGridViewOdjeca.CurrentRow.Cells[0].Value.ToString());
            int velicina = int.Parse(dataGridViewVelicine.CurrentRow.Cells[0].Value.ToString());

            string sql = "INSERT INTO odjeca_velicina(vk_odjeca,vk_velicina) VALUES(" + odjeca + "," + velicina + ");";


            
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcijaSpremanja.conn);
            command.ExecuteReader();

            PrikazPodatakaVelicineOdjece();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            SpremiVelicinuOdjece();
        }

        private void DostupneVelicineOdjece_Load(object sender, EventArgs e)
        {
            konekcijaSpremanja.ZatvoriKonekciju();
        }
    }
}
