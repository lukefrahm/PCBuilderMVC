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
    /// GPU accessor to communicate with database on GPU objects.
    /// </summary>
    public class GPUAccessor
    {
        /// <summary>
        /// Retrieves a GPU by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>A GPU object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static GPU RetrieveGPUByName(string name)
        {
            GPU gpu;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_gpu_by_name";
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
                    gpu = new GPU()
                    {
                        GpuId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        ClockSpeed = reader.GetDouble(3),
                        ProductLineName = reader.GetString(4),
                        BenchmarkScore = reader.GetInt32(5),
                        BestUse = reader.GetString(6),
                        GpuRamSize = reader.GetInt32(7),
                        PciPinConnector1 = reader.GetInt32(8),
                        PciPinConnector2 = reader.GetInt32(9),
                        PciPinConnector3 = reader.GetInt32(10),
                        PowerRequirement = reader.GetInt32(11),
                        GpuLength = reader.GetString(12)[0],
                        Price = reader.GetDecimal(13)
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
            return gpu;
        }

        /// <summary>
        /// Retrieves lsit of GPUs by RAM size.
        /// </summary>
        /// <param name="ramSize">Size of the ram.</param>
        /// <returns>List of GPU objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<GPU> RetrieveGPUsByRamSize(int ramSize)
        {
            var gpus = new List<GPU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_gpus_by_ram_size";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RamSize", ramSize);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        gpus.Add(new GPU()
                        {
                            GpuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            ClockSpeed = reader.GetDouble(3),
                            ProductLineName = reader.GetString(4),
                            BenchmarkScore = reader.GetInt32(5),
                            BestUse = reader.GetString(6),
                            GpuRamSize = reader.GetInt32(7),
                            PciPinConnector1 = reader.GetInt32(8),
                            PciPinConnector2 = reader.GetInt32(9),
                            PciPinConnector3 = reader.GetInt32(10),
                            PowerRequirement = reader.GetInt32(11),
                            GpuLength = reader.GetString(12)[0],
                            Price = reader.GetDecimal(13)
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
            return gpus;
        }

        /// <summary>
        /// Inserts a new GPU.
        /// </summary>
        /// <param name="gpu">The gpu.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertGpu(GPU gpu)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_gpu";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", gpu.Brand);
            cmd.Parameters.AddWithValue("@Model", gpu.Model);
            cmd.Parameters.AddWithValue("@ClockSpeed", gpu.ClockSpeed);
            cmd.Parameters.AddWithValue("@ProductLineName", gpu.ProductLineName);
            cmd.Parameters.AddWithValue("@BenchmarkScore", gpu.BenchmarkScore);
            cmd.Parameters.AddWithValue("@BestUse", gpu.BestUse);
            cmd.Parameters.AddWithValue("@GpuRamSize", gpu.GpuRamSize);
            cmd.Parameters.AddWithValue("@PciPinConnector1", gpu.PciPinConnector1);
            cmd.Parameters.AddWithValue("@PciPinConnector2", gpu.PciPinConnector2);
            cmd.Parameters.AddWithValue("@PciPinConnector3", gpu.PciPinConnector3);
            cmd.Parameters.AddWithValue("@PowerRequirement", gpu.PowerRequirement);
            cmd.Parameters.AddWithValue("@GpuLength", gpu.GpuLength);
            cmd.Parameters.AddWithValue("@Price", gpu.Price);

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
        /// Retrieves all GPUs.
        /// </summary>
        /// <returns>List of GPU objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<GPU> RetrieveAllGPU()
        {
            var gpus = new List<GPU>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_gpus";
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
                        gpus.Add(new GPU()
                        {
                            GpuId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            ClockSpeed = reader.GetDouble(3),
                            ProductLineName = reader.GetString(4),
                            BenchmarkScore = reader.GetInt32(5),
                            BestUse = reader.GetString(6),
                            GpuRamSize = reader.GetInt32(7),
                            PciPinConnector1 = reader.GetInt32(8),
                            PciPinConnector2 = reader.GetInt32(9),
                            PciPinConnector3 = reader.GetInt32(10),
                            PowerRequirement = reader.GetInt32(11),
                            GpuLength = reader.GetString(12)[0],
                            Price = reader.GetDecimal(13)
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
            return gpus;
        }
    }
}
