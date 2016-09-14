using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// PSU accessor to communicate with database on PSU objects.
    /// </summary>
    public class PSUAccessor
    {
        /// <summary>
        /// Retrieves a PSU by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>PSU object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static PSU RetrievePSUByName(string name)
        {
            PSU psu;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_psu_by_name";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Model", name);

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    psu = new PSU()
                    {
                        PsuId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        Wattage = reader.GetInt32(3),
                        Efficiency = reader.GetString(4),
                        Price = reader.GetDecimal(5)
                    };
                }
                else
                {
                    throw new ApplicationException("Data not found");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return psu;
        }

        /// <summary>
        /// Retrieves PSUs by wattage.
        /// </summary>
        /// <param name="wattage">The wattage.</param>
        /// <returns>Lsit of PSUs.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<PSU> RetrievePSUsByWattage(string wattage)
        {
            var psus = new List<PSU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_psus_by_wattage";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Wattage", wattage);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        psus.Add(new PSU()
                        {
                            PsuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Wattage = reader.GetInt32(3),
                            Efficiency = reader.GetString(4),
                            Price = reader.GetDecimal(5)
                        });
                    }
                }
                else
                {
                    throw new ApplicationException("Data not found");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return psus;
        }

        /// <summary>
        /// Inserts a new PSU.
        /// </summary>
        /// <param name="psu">The psu.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertPSU(PSU psu)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_psu";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", psu.Brand);
            cmd.Parameters.AddWithValue("@Model", psu.Model);
            cmd.Parameters.AddWithValue("@Wattage", psu.Wattage);
            cmd.Parameters.AddWithValue("@Efficiency", psu.Efficiency);
            cmd.Parameters.AddWithValue("@Price", psu.Price);

            try
            {
                conn.Open();

                count = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        /// <summary>
        /// Retrieves all PSUs.
        /// </summary>
        /// <returns>List of PSU</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<PSU> RetrieveAllPSU()
        {
            var psus = new List<PSU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_psus";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        psus.Add(new PSU()
                        {
                            PsuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Wattage = reader.GetInt32(3),
                            Efficiency = reader.GetString(4),
                            Price = reader.GetDecimal(5)
                        });
                    }
                }
                else
                {
                    throw new ApplicationException("Data not found.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return psus;
        }
    }
}