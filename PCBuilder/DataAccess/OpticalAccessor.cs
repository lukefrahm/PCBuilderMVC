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
    /// Optical accessor to communicate with database on Optical drive objects.
    /// </summary>
    public class OpticalAccessor
    {
        /// <summary>
        /// Retrieves optical drive by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Optical drive object</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static Optical RetrieveOpticalByName(string name)
        {
            Optical optical;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_optical_by_name";
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
                    optical = new Optical()
                    {
                        OpticalId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        OpticalType = reader.GetString(3),
                        Price = reader.GetDecimal(4)
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
            return optical;
        }

        /// <summary>
        /// Retrieves optical drives by type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>List of optical drives.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<Optical> RetrieveOpticalsByType(string type)
        {
            var opticals = new List<Optical>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_optical_by_type";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OpticalType", type);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        opticals.Add(new Optical()
                        {
                            OpticalId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            OpticalType = reader.GetString(3),
                            Price = reader.GetDecimal(4)
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
            return opticals;
        }

        /// <summary>
        /// Inserts a new optical drive.
        /// </summary>
        /// <param name="optical">The optical.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertOptical(Optical optical)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_optical";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", optical.Brand);
            cmd.Parameters.AddWithValue("@Model", optical.Model);
            cmd.Parameters.AddWithValue("@OpticalType", optical.OpticalType);
            cmd.Parameters.AddWithValue("@Price", optical.Price);

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
    }
}
