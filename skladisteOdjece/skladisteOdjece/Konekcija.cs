using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace skladisteOdjece
{
    public class Konekcija
    {
        public NpgsqlConnection conn;
        public void OtvoriKonekciju()
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234; Database=ducan_odjeca");
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }
        public void ZatvoriKonekciju()
        {
            conn.Close();
        }
    }
}
