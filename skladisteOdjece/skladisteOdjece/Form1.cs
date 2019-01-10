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

        public void Povezivanje()
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234; Database=ducan_odjeca");
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                // quite complex sql statement
                string sql = "SELECT * FROM spol";
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
               
            }
        }
    }
}
