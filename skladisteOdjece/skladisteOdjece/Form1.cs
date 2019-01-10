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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Povezivanje();
        }
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private Konekcija konekcija;

        public void Povezivanje()
        {
                konekcija = new Konekcija();
        
                string sql = "SELECT * FROM spol";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.OtvoriKonekciju());
            
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                konekcija.ZatvoriKonekciju();
            
        }
    }
}
