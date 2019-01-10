using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace skladisteOdjece
{
    class Konekcija
    {
        private NpgsqlConnection conn;
        public NpgsqlConnection OtvoriKonekciju()
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234; Database=ducan_odjeca");
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            return conn;
        }
        public void ZatvoriKonekciju()
        {
            conn.Close();
        }
    }
}
