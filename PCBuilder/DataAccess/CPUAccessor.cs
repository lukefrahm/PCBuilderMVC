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
    /// CPU accessor to communicate with database on CPU objects.
    /// </summary>
    public class CPUAccessor
    {
        /// <summary>
        /// Retrieves a CPU by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>CPU object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static CPU RetrieveCPUByName(string name)
        {
            CPU cpu;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_cpu_by_name";
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
                    cpu = new CPU()
                    {
                        CpuId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        Cores = reader.GetInt32(3),
                        HyperThreaded = reader.GetBoolean(4),
                        ClockSpeed = reader.GetDouble(5),
                        Unlocked = reader.GetBoolean(6),
                        Socket = reader.GetString(7),
                        ProductLineName = reader.GetString(8),
                        BenchmarkScore = reader.GetInt32(9),
                        BestUse = reader.GetString(10),
                        PowerRequirement = reader.GetInt32(11),
                        Price = reader.GetDecimal(12)
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
            return cpu;
        }

        /// <summary>
        /// Retrieves CPUs by core count.
        /// </summary>
        /// <param name="cores">The cores.</param>
        /// <returns>List of CPU objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<CPU> RetrieveCPUsByCoreCount(int cores)
        {
            var cpus = new List<CPU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_cpus_by_core_count";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cores", cores);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cpus.Add(new CPU()
                        {
                            CpuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Cores = reader.GetInt32(3),
                            HyperThreaded = reader.GetBoolean(4),
                            ClockSpeed = reader.GetDouble(5),
                            Unlocked = reader.GetBoolean(6),
                            Socket = reader.GetString(7),
                            ProductLineName = reader.GetString(8),
                            BenchmarkScore = reader.GetInt32(9),
                            BestUse = reader.GetString(10),
                            PowerRequirement = reader.GetInt32(11),
                            Price = reader.GetDecimal(12)
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
            return cpus;
        }

        /// <summary>
        /// Inserts a new CPU.
        /// </summary>
        /// <param name="cpu">The cpu.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertCpu(CPU cpu)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_cpu";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", cpu.Brand);
            cmd.Parameters.AddWithValue("@Model", cpu.Model);
            cmd.Parameters.AddWithValue("@Cores", cpu.Cores);
            cmd.Parameters.AddWithValue("@HyperThreaded", cpu.HyperThreaded);
            cmd.Parameters.AddWithValue("@ClockSpeed", cpu.ClockSpeed);
            cmd.Parameters.AddWithValue("@Unlocked", cpu.Unlocked);
            cmd.Parameters.AddWithValue("@Socket", cpu.Socket);
            cmd.Parameters.AddWithValue("@ProductLineName", cpu.ProductLineName);
            cmd.Parameters.AddWithValue("@BenchmarkScore", cpu.BenchmarkScore);
            cmd.Parameters.AddWithValue("@BestUse", cpu.BestUse);
            cmd.Parameters.AddWithValue("@PowerRequirement", cpu.PowerRequirement);
            cmd.Parameters.AddWithValue("@Price", cpu.Price);

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
        /// Retrieves all CPUs.
        /// </summary>
        /// <returns>Lsit of CPU objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<CPU> RetrieveAllCPU()
        {
            var cpus = new List<CPU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_cpus";
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
                        cpus.Add(new CPU()
                        {
                            CpuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Cores = reader.GetInt32(3),
                            HyperThreaded = reader.GetBoolean(4),
                            ClockSpeed = reader.GetDouble(5),
                            Unlocked = reader.GetBoolean(6),
                            Socket = reader.GetString(7),
                            ProductLineName = reader.GetString(8),
                            BenchmarkScore = reader.GetInt32(9),
                            BestUse = reader.GetString(10),
                            PowerRequirement = reader.GetInt32(11),
                            Price = reader.GetDecimal(12)
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
            return cpus;
        }
    }
}
