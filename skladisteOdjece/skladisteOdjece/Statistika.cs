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
using ZedGraph;


namespace skladisteOdjece
{
    public partial class Statistika : Form
    {
        private Konekcija konekcija;
       
        public Statistika()
        {
            InitializeComponent();

            konekcija = new Konekcija();
            konekcija.OtvoriKonekciju();
        }

        private void NarudzbeNaCekanju()
        {
            string datumOd = "";
            datumOd = datumOd + dateTimePickerOd1.Value.Year + "-";
            datumOd = datumOd + dateTimePickerOd1.Value.Month + "-";
            datumOd = datumOd + dateTimePickerOd1.Value.Day;

            string datumDo = "";
            datumDo = datumDo + dateTimePickerDo1.Value.Year + "-";
            datumDo = datumDo + dateTimePickerDo1.Value.Month + "-";
            datumDo = datumDo + dateTimePickerDo1.Value.Day;

            string sql = "SELECT COUNT(id) FROM narudzbenica WHERE zaprimljeno=false AND datum>'"+datumOd+"' AND datum<'"+datumDo+"';";
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);

            string broj = command.ExecuteScalar().ToString();

            labelNaČekanju.Text = broj;
        }

        private void IzvrseneNarudzbe()
        {
            string datumOd = "";
            datumOd = datumOd + dateTimePickerOd2.Value.Year + "-";
            datumOd = datumOd + dateTimePickerOd2.Value.Month + "-";
            datumOd = datumOd + dateTimePickerOd2.Value.Day;

            string datumDo = "";
            datumDo = datumDo + dateTimePickerDo2.Value.Year + "-";
            datumDo = datumDo + dateTimePickerDo2.Value.Month + "-";
            datumDo = datumDo + dateTimePickerDo2.Value.Day;

            string sql = "SELECT COUNT(id) FROM narudzbenica WHERE zaprimljeno=true AND datum>'" + datumOd + "' AND datum<'" + datumDo + "';";
            NpgsqlCommand command = new NpgsqlCommand(sql, konekcija.conn);

            string broj = command.ExecuteScalar().ToString();

            labelIzvršeno.Text = broj;
        }

        private void Top5()
        {
            string datumOd = "";
            datumOd = datumOd + dateTimePickerOd3.Value.Year + "-";
            datumOd = datumOd + dateTimePickerOd3.Value.Month + "-";
            datumOd = datumOd + dateTimePickerOd3.Value.Day;

            string datumDo = "";
            datumDo = datumDo + dateTimePickerDo3.Value.Year + "-";
            datumDo = datumDo + dateTimePickerDo3.Value.Month + "-";
            datumDo = datumDo + dateTimePickerDo3.Value.Day;
            

            string sql = "SELECT es.vk_odjeca AS Oznaka,COUNT(es.vk_odjeca) AS Kolicina,o.naziv AS Naziv,v.oznaka AS Velicina FROM evidencija_sk es JOIN odjeca_velicina ov ON es.vk_odjeca=ov.id JOIN velicina v ON ov.vk_velicina=v.id JOIN odjeca o ON ov.vk_odjeca=o.id WHERE vrsta_posla LIKE 'Oduzeto' AND datum_evidencije>'" + datumOd+"' AND datum_evidencije<'"+datumDo+ "'  GROUP BY 1,3,4 ORDER BY 2 DESC LIMIT 5;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
           
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;


            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    chart1.Series["Odjeća"].Points.AddXY(row["Naziv"].ToString()+" "+row["Velicina"].ToString(), row["Kolicina"].ToString());                     
                }
            }

        }

        private void buttonOdredi1_Click(object sender, EventArgs e)
        {
            NarudzbeNaCekanju();
        }

        private void buttonOdredi2_Click(object sender, EventArgs e)
        {
            IzvrseneNarudzbe();
        }


        private void Statistika_Leave(object sender, EventArgs e)
        {
            konekcija.ZatvoriKonekciju();
        }

        private void buttonOdredi3_Click(object sender, EventArgs e)
        {
            Top5();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
