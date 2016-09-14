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
    /// Motherboard accessor to communicate with database on Motherboard objects.
    /// </summary>
    public class MotherboardAccessor
    {
        /// <summary>
        /// Retrieves a motherboard by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Motherboard object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static Motherboard RetrieveMotherboardByName(string name)
        {
            Motherboard motherboard;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_motherboard_by_name";
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
                    motherboard = new Motherboard()
                    {
                        MotherboardId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        Socket = reader.GetString(3),
                        Chipset = reader.GetString(4),
                        MaxRam = reader.GetInt32(5),
                        RamType = reader.GetInt32(6),
                        FormFactor = reader.GetString(7),
                        SataPorts = reader.GetInt32(8),
                        M2Slots = reader.GetInt32(9),
                        PowerPhases = reader.GetInt32(10),
                        FanHeaders = reader.GetInt32(11),
                        Pcie16 = reader.GetInt32(12),
                        Pcie8 = reader.GetInt32(13),
                        Pcie4 = reader.GetInt32(14),
                        Pcie1 = reader.GetInt32(15),
                        Pci = reader.GetInt32(16),
                        Price = reader.GetDecimal(17)
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
            return motherboard;
        }

        /// <summary>
        /// Retrieves list of motherboards by socket.
        /// </summary>
        /// <param name="socket">The socket.</param>
        /// <returns>List of motherboards</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<Motherboard> RetrieveMotherboardsBySocket(string socket)
        {
            var motherboards = new List<Motherboard>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_motherboards_by_socket";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Socket", socket);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        motherboards.Add(new Motherboard()
                        {
                            MotherboardId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Socket = reader.GetString(3),
                            Chipset = reader.GetString(4),
                            MaxRam = reader.GetInt32(5),
                            RamType = reader.GetInt32(6),
                            FormFactor = reader.GetString(7),
                            SataPorts = reader.GetInt32(8),
                            M2Slots = reader.GetInt32(9),
                            PowerPhases = reader.GetInt32(10),
                            FanHeaders = reader.GetInt32(11),
                            Pcie16 = reader.GetInt32(12),
                            Pcie8 = reader.GetInt32(13),
                            Pcie4 = reader.GetInt32(14),
                            Pcie1 = reader.GetInt32(15),
                            Pci = reader.GetInt32(16),
                            Price = reader.GetDecimal(17)
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
            return motherboards;
        }

        /// <summary>
        /// Inserts a new motherboard.
        /// </summary>
        /// <param name="motherboard">The motherboard.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertMotherboard(Motherboard motherboard)
        { 
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_motherboard";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", motherboard.Brand);
            cmd.Parameters.AddWithValue("@Model", motherboard.Model);
            cmd.Parameters.AddWithValue("@Socket", motherboard.Socket);
            cmd.Parameters.AddWithValue("@Chipset", motherboard.Chipset);
            cmd.Parameters.AddWithValue("@MaxRam", motherboard.MaxRam);
            cmd.Parameters.AddWithValue("@RamType", motherboard.RamType);
            cmd.Parameters.AddWithValue("@FormFactor", motherboard.FormFactor);
            cmd.Parameters.AddWithValue("@SataPorts", motherboard.SataPorts);
            cmd.Parameters.AddWithValue("@M2Slots", motherboard.M2Slots);
            cmd.Parameters.AddWithValue("@PowerPhases", motherboard.PowerPhases);
            cmd.Parameters.AddWithValue("@FanHeaders", motherboard.FanHeaders);
            cmd.Parameters.AddWithValue("@Pcie16", motherboard.Pcie16);
            cmd.Parameters.AddWithValue("@Pcie8", motherboard.Pcie8);
            cmd.Parameters.AddWithValue("@Pcie4", motherboard.Pcie4);
            cmd.Parameters.AddWithValue("@Pcie1", motherboard.Pcie1);
            cmd.Parameters.AddWithValue("@Pci", motherboard.Pci);
            cmd.Parameters.AddWithValue("@Price", motherboard.Price);

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
        /// Retrieves all motherboards.
        /// </summary>
        /// <returns>List of motherboards</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<Motherboard> RetrieveAllMotherboards()
        {
            var motherboards = new List<Motherboard>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_motherboards";
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
                        motherboards.Add(new Motherboard()
                        {
                            MotherboardId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Socket = reader.GetString(3),
                            Chipset = reader.GetString(4),
                            MaxRam = reader.GetInt32(5),
                            RamType = reader.GetInt32(6),
                            FormFactor = reader.GetString(7),
                            SataPorts = reader.GetInt32(8),
                            M2Slots = reader.GetInt32(9),
                            PowerPhases = reader.GetInt32(10),
                            FanHeaders = reader.GetInt32(11),
                            Pcie16 = reader.GetInt32(12),
                            Pcie8 = reader.GetInt32(13),
                            Pcie4 = reader.GetInt32(14),
                            Pcie1 = reader.GetInt32(15),
                            Pci = reader.GetInt32(16),
                            Price = reader.GetDecimal(17)
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
            return motherboards;
        }
    }
}
