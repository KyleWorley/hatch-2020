using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Repo
    {
        private string connectionString = "Data Source=Tonya-PC-2019;Initial Catalog=HATCH;Integrated Security=True";
        public Repo()
        {
        }

        public string GetIndividual(int IndividualId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand("select top 1 * from HATCH..Individual", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return reader.GetInt32(0).ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                return e.Message;
            }

            return "nothing";
        }
    }
}
