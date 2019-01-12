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
        private int idVrsta;
        private int idUzrast;
        private char idSpol;
        private int idMaterijal;
        private int idOdjece;

        private DataGridViewRow odjeca;

        public UnosIzmjenaAsortimana()
        {
            InitializeComponent();
            konekcija = new Konekcija();
            konekcija.OtvoriKonekciju();

            PuniCombobox();
        }

        public UnosIzmjenaAsortimana(int idOdjece, DataGridViewRow odjeca)
        {
            InitializeComponent();
            konekcija = new Konekcija();
            konekcija.OtvoriKonekciju();

            izmjena = true;

            this.idOdjece = idOdjece;

            textBoxNaziv.Text=odjeca.Cells[1].Value.ToString();
            textBoxOpis.Text = odjeca.Cells[2].Value.ToString();
            textBoxZemlja.Text = odjeca.Cells[7].Value.ToString();
            textBoxMinKol.Text = odjeca.Cells[9].Value.ToString();
            textBoxKolNar.Text = odjeca.Cells[10].Value.ToString();

            labelNaslov.Text = "Izmjena odjece: " + idOdjece;

            PuniCombobox();
        }

        private void PuniCombobox()
        {
            string sqlVrsta = "SELECT id,naziv,opis FROM vrsta;";
            DataSet dsVrsta = new DataSet();
            DataTable dtVrsta = new DataTable();
            NpgsqlDataAdapter daVrsta = new NpgsqlDataAdapter(sqlVrsta, konekcija.conn);
            dsVrsta.Reset();
            daVrsta.Fill(dsVrsta);
            dtVrsta = dsVrsta.Tables[0];
            dataGridViewVrsta.DataSource = dtVrsta;

            string sqlUzrast = "SELECT id,naziv,opis FROM uzrast;";
            DataSet dsUzrast = new DataSet();
            DataTable dtUzrast = new DataTable();
            NpgsqlDataAdapter daUzrast = new NpgsqlDataAdapter(sqlUzrast, konekcija.conn);
            dsUzrast.Reset();
            daUzrast.Fill(dsUzrast);
            dtUzrast = dsUzrast.Tables[0];
            dataGridViewUzrast.DataSource = dtUzrast;

            string sqlSpol = "SELECT spol FROM spol;";
            DataSet dsSpol = new DataSet();
            DataTable dtSpol = new DataTable();
            NpgsqlDataAdapter daSpol = new NpgsqlDataAdapter(sqlSpol, konekcija.conn);
            dsSpol.Reset();
            daSpol.Fill(dsSpol);
            dtSpol = dsSpol.Tables[0];
            dataGridViewSpol.DataSource = dtSpol;

            string sqlMaterijal = "SELECT id,naziv,opis FROM materijal;";
            DataSet dsMaterijal = new DataSet();
            DataTable dtMaterijal = new DataTable();
            NpgsqlDataAdapter daMaterijal = new NpgsqlDataAdapter(sqlMaterijal, konekcija.conn);
            dsMaterijal.Reset();
            daMaterijal.Fill(dsMaterijal);
            dtMaterijal = dsMaterijal.Tables[0];
            dataGridViewMaterijal.DataSource = dtMaterijal;
        }

        private void PohraniNovuRobu()
        {
            string naziv = textBoxNaziv.Text;
            string opis = textBoxOpis.Text;
            string zemlja = textBoxZemlja.Text;
            int minKol =int.Parse(textBoxMinKol.Text);
            int kolNar =int.Parse(textBoxKolNar.Text);
            string datum = "";
            datum = datum+ dateTimePicker1.Value.Year+"-";
            datum = datum+ dateTimePicker1.Value.Month+"-";
            datum = datum+ dateTimePicker1.Value.Day;

            string sql = "INSERT INTO odjeca(naziv,opis,vk_vrsta,vk_uzrast,vk_spol,vk_materijal,zemlja_proizvodnje,godina,min_kolicina,kolicina_narucivanja) " +
                "VALUES('"+naziv+"','"+opis+"',"+idVrsta+","+idUzrast+",'"+idSpol+"',"+idMaterijal+",'"+zemlja+"','"+datum+"',"+minKol+","+kolNar+");";
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);
            command.ExecuteReader();
        }

        private void IzmjeniRobu()
        {
            string naziv = textBoxNaziv.Text;
            string opis = textBoxOpis.Text;
            string zemlja = textBoxZemlja.Text;
            int minKol = int.Parse(textBoxMinKol.Text);
            int kolNar = int.Parse(textBoxKolNar.Text);
            string datum = "";
            datum = datum + dateTimePicker1.Value.Year + "-";
            datum = datum + dateTimePicker1.Value.Month + "-";
            datum = datum + dateTimePicker1.Value.Day;

            string sql = "UPDATE odjeca SET " +
                "naziv='"+naziv+"'," +
                "opis='"+opis+"'," +
                "vk_vrsta="+idVrsta+"," +
                "vk_uzrast="+idUzrast+"," +
                "vk_spol=?"+idSpol+"'," +
                "vk_materijal="+idMaterijal+"," +
                "zemlja_proizvodnje='"+zemlja+"'," +
                "godina='"+datum+"'," +
                "min_kolicina="+minKol+"," +
                "kolicina_narucivanja="+kolNar+" " +
                "WHERE id="+idOdjece+";";
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);
            command.ExecuteReader();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if (izmjena)
                IzmjeniRobu();
            else
                PohraniNovuRobu();

            konekcija.ZatvoriKonekciju();

            this.Close();
        }

        private void dataGridViewVrsta_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idVrsta = int.Parse(dataGridViewVrsta.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }

        private void dataGridViewUzrast_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idUzrast = int.Parse(dataGridViewUzrast.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }

        private void dataGridViewSpol_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idSpol = char.Parse(dataGridViewSpol.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }

        private void dataGridViewMaterijal_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idMaterijal = int.Parse(dataGridViewMaterijal.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }
    }
}
