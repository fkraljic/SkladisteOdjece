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

            dateTimePickerVdO.Format = DateTimePickerFormat.Time;
            dateTimePickerVdO.ShowUpDown = true;

            dateTimePickerVoD.Format = DateTimePickerFormat.Time;
            dateTimePickerVoD.ShowUpDown = true;

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

        private void PrikazPodatakaEvidencijeFilter(string odV,string doV)
        {
            string sql = "SELECT e.id AS Evidencija_ID,o.id AS Odjeca_ID,ov.id AS Velicina_ID,o.naziv AS Naziv,v.oznaka AS Velicina,e.datum_evidencije AS Datum,e.stara_kolicina AS Stara_kolicina,e.nova_kolicina AS Nova_kolicina, e.vrsta_posla AS Vrsta FROM " +
                "evidencija_sk e JOIN odjeca_velicina ov ON e.vk_odjeca=ov.id " +
                "JOIN odjeca o ON ov.vk_odjeca=o.id " +
                "JOIN velicina v ON v.id=ov.vk_velicina WHERE e.datum_evidencije>'"+odV +"' AND e.datum_evidencije<'"+doV+"' "+
                "ORDER BY 6 ASC;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            string godinaOd = dateTimePickerOd.Value.Year.ToString();
            string mjesecOd = dateTimePickerOd.Value.Month.ToString();
            string danOd = dateTimePickerOd.Value.Day.ToString();

            string satiOd = dateTimePickerVoD.Value.Hour.ToString();
            string minOd = dateTimePickerVoD.Value.Minute.ToString();

            string godinaDo = dateTimePickerDo.Value.Year.ToString();
            string mjesecDo = dateTimePickerDo.Value.Month.ToString();
            string danDo = dateTimePickerDo.Value.Day.ToString();

            string satiDo = dateTimePickerVdO.Value.Hour.ToString();
            string minDo = dateTimePickerVdO.Value.Minute.ToString();

            string odV = godinaOd + "-" + mjesecOd + "-" + danOd + " " + satiOd + ":" + minOd + ":" + "00";
            string doV = godinaDo + "-" + mjesecDo + "-" + danDo + " " + satiDo + ":" + minDo + ":" + "00";

            PrikazPodatakaEvidencijeFilter(odV,doV);



        }
    }
}
