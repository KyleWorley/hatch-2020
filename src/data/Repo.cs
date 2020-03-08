using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hatch.Data.Repositories
{
    public class Repo
    {
        private string connectionString = "Data Source=Tonya-PC-2019;Initial Catalog=HATCH;Integrated Security=True";
        public Repo()
        {
        }

        public string GetIndividual(int individualId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("CustOrderHist", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@fk_individual_id", individualId));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var localIndividualId = rdr["rec_id"];
                            var name = rdr["name"];
                            var sex = rdr["sex"];
                            var living = rdr["living"];
                        }

                        rdr.NextResult();
                        while (rdr.Read())
                        {
                            var localIndividualId1 = rdr["fk_individual_1"];
                            var localIndividualId2 = rdr["fk_individual_2"];
                            var reportingIndividuailId = rdr["fk_reporting_individual"];
                            var relation = rdr["relation_1_to_2_type_cd"];
                        }

                        rdr.NextResult();
                        while (rdr.Read())
                        {
                            var disease = rdr["name"];
                            var localIndividualId = rdr["fk_individual"];
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