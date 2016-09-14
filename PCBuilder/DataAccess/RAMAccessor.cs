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
    /// RAM accessor to communicate with database on RAM objects.
    /// </summary>
    public class RAMAccessor
    {
        /// <summary>
        /// Retrieves RAM objects by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>RAM object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static RAM RetrieveRAMByName(string name)
        {
            RAM ram;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_ram_by_name";
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
                    ram = new RAM()
                    {
                        RamId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        RamSize = reader.GetInt32(3),
                        RamGeneration = reader.GetInt32(4),
                        RamSpeed = reader.GetInt32(5),
                        RamTimings = reader.GetString(6),
                        BestUse = reader.GetString(7),
                        Price = reader.GetDecimal(8)
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
            return ram;
        }

        /// <summary>
        /// Retrieves a lsit of RAM by size..
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>Lsit of RAM.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<RAM> RetrieveRAMsByRamSize(int size)
        {
            var rams = new List<RAM>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_rams_by_ram_size";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RamSize", size);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rams.Add(new RAM()
                        {
                            RamId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            RamSize = reader.GetInt32(3),
                            RamGeneration = reader.GetInt32(4),
                            RamSpeed = reader.GetInt32(5),
                            RamTimings = reader.GetString(6),
                            BestUse = reader.GetString(7),
                            Price = reader.GetDecimal(8)
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
            return rams;
        }

        /// <summary>
        /// Inserts a new RAM object.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <returns>Count of records affected.</returns>
        public static int InsertRam(RAM ram)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_ram";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", ram.Brand);
            cmd.Parameters.AddWithValue("@Model", ram.Model);
            cmd.Parameters.AddWithValue("@RamSize", ram.RamSize);
            cmd.Parameters.AddWithValue("@RamGeneration", ram.RamGeneration);
            cmd.Parameters.AddWithValue("@RamSpeed", ram.RamSpeed);
            cmd.Parameters.AddWithValue("@RamTimings", ram.RamTimings);
            cmd.Parameters.AddWithValue("@BestUse", ram.BestUse);
            cmd.Parameters.AddWithValue("@Price", ram.Price);

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
        /// Retrieves all ram.
        /// </summary>
        /// <returns>List of RAM.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<RAM> RetrieveAllRAM()
        {
            var rams = new List<RAM>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_rams";
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
                        rams.Add(new RAM()
                        {
                            RamId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            RamSize = reader.GetInt32(3),
                            RamGeneration = reader.GetInt32(4),
                            RamSpeed = reader.GetInt32(5),
                            RamTimings = reader.GetString(6),
                            BestUse = reader.GetString(7),
                            Price = reader.GetDecimal(8)
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
            return rams;
        }
    }
}
