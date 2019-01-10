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
            Povezivanje();
        }        

        public void Povezivanje()
        {        
            string sql = "SELECT * FROM spol";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);


            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

                     
        }

        private void buttonStanjeSkladista_Click(object sender, EventArgs e)
        {
            StanjeSkladišta stanjeSkladišta = new StanjeSkladišta(konekcija);
            stanjeSkladišta.ShowDialog();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {
            konekcija.ZatvoriKonekciju();
        }
    }
}
