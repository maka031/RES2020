using Funkcije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnagaSunca;
using System.Data.SqlClient;
using Komponente;

namespace SHES
{
    public class Metode : IMetode
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True";

        public void TrenutnaSnagaPanela(int sSunca)
        {
            int snagaP = 0;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string pomocni = "SELECT maxSnaga FROM Panel WHERE ime=@ime";
                SqlCommand komanda = new SqlCommand(pomocni, connection);
                SqlDataReader da = komanda.ExecuteReader();

                while (da.Read())
                {
                    snagaP = Int32.Parse(da.GetValue(0).ToString());
                }
                SolarniPanel sp = new SolarniPanel();
                sp.TrenutnaSnaga = snagaP * 1 / sSunca;

            }

            
            
        }
    }
}
