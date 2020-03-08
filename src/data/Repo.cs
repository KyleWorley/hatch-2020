using data.Models;
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
        private string connectionString = "Data Source=Tonya-PC-2019;Initial Catalog=HATCH;Integrated Security=True;User Id=Everyone;password=good_password";
        public Repo()
        {
        }

        public Family GetFamily(int individualId)
        {
            var family = new Family();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_family_get_by_individual", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@fk_individual_id", individualId));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            bool? living = null;
                            try
                            {
                                living = rdr.GetBoolean("living");
                            }
                            catch
                            {

                            }
                            var localIndividualId = (int)rdr["rec_id"];
                            var name = (string)rdr["name"];
                            var sex = (Sex)Enum.Parse(typeof(Sex), (string)rdr["sex"]);

                            if (!family.Individuals.ContainsKey(localIndividualId))
                            {
                                family.Individuals.Add(localIndividualId, new Individual
                                {
                                    Name = name,
                                    Sex = sex,
                                    Living = living,
                                    Id = localIndividualId
                                });
                            }
                        }

                        rdr.NextResult();
                        while (rdr.Read())
                        {
                            var localIndividualId1 = (int)rdr["fk_individual_1"];
                            var localIndividualId2 = (int)rdr["fk_individual_2"];
                            var reportingIndividuailId = (int)rdr["fk_reporting_individual"];
                            var relation = (RelationType)rdr["relation_1_to_2_type_cd"];

                            if (family.Individuals.ContainsKey(localIndividualId1))
                            {
                                if (!family.Individuals[localIndividualId1].Relations.ContainsKey(localIndividualId2))
                                {
                                    family.Individuals[localIndividualId1].Relations.Add(localIndividualId2, new Relation
                                    {
                                        ReportedBy = reportingIndividuailId,
                                        Type = relation
                                    });
                                }
                            }
                        }

                        rdr.NextResult();
                        while (rdr.Read())
                        {
                            var disease = (string)rdr["name"];
                            var localIndividualId = (int)rdr["fk_individual"];
                            var ageOfOnset = (int)rdr["age_of_onset"];

                            if (family.Individuals.ContainsKey(localIndividualId))
                            {
                                family.Individuals[localIndividualId].Diseases.Add(new Disease
                                {
                                    AgeOfOnSet = ageOfOnset,
                                    Name = disease
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
            }

            return family;
        }
    }
}