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
    /// Storage accessor to communicate with database on storage objects.
    /// </summary>
    public class StorageAccessor
    {
        /// <summary>
        /// Retrieves storage components by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Storage object.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static Storage RetrieveStorageByName(string name)
        {
            Storage storage;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_storage_by_name";
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
                    storage = new Storage()
                    {
                        StorageId = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        StorageSize = reader.GetInt32(3),
                        StorageType = reader.GetString(4),
                        BenchmarkScore = reader.GetInt32(5),
                        StorageSequentialRead = reader.GetInt32(6),
                        StorageSequentialWrite = reader.GetInt32(7),
                        StorageRandomRead = reader.GetInt32(8),
                        StorageRandomWrite = reader.GetInt32(9),
                        BestUse = reader.GetString(10),
                        Price = reader.GetDecimal(11)
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
            return storage;
        }

        /// <summary>
        /// Retrieves list of storage objects by storage size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>List of storage objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<Storage> RetrieveStorageBySize(int size)
        {
            var storage = new List<Storage>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_storage_by_size";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StorageSize", size);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        storage.Add(new Storage()
                        {
                            StorageId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            StorageSize = reader.GetInt32(3),
                            StorageType = reader.GetString(4),
                            BenchmarkScore = reader.GetInt32(5),
                            StorageSequentialRead = reader.GetInt32(6),
                            StorageSequentialWrite = reader.GetInt32(7),
                            StorageRandomRead = reader.GetInt32(8),
                            StorageRandomWrite = reader.GetInt32(9),
                            BestUse = reader.GetString(10),
                            Price = reader.GetDecimal(11)
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
            return storage;
        }

        /// <summary>
        /// Retrieves a lsit of storage objects by type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Lsit of storage objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found</exception>
        public static List<Storage> RetrieveStorageByType(string type)
        {
            var storage = new List<Storage>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_storage_by_type";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StorageType", type);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        storage.Add(new Storage()
                        {
                            StorageId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            StorageSize = reader.GetInt32(3),
                            StorageType = reader.GetString(4),
                            BenchmarkScore = reader.GetInt32(5),
                            StorageSequentialRead = reader.GetInt32(6),
                            StorageSequentialWrite = reader.GetInt32(7),
                            StorageRandomRead = reader.GetInt32(8),
                            StorageRandomWrite = reader.GetInt32(9),
                            BestUse = reader.GetString(10),
                            Price = reader.GetDecimal(11)
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
            return storage;
        }

        /// <summary>
        /// Inserts a new storage object.
        /// </summary>
        /// <param name="storage">The storage.</param>
        /// <returns>Count of rows affected.</returns>
        public static int InsertStorage(Storage storage)
        {
            int count = 0;

            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_storage";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Brand", storage.Brand);
            cmd.Parameters.AddWithValue("@Model", storage.Model);
            cmd.Parameters.AddWithValue("@StorageSize", storage.StorageSize);
            cmd.Parameters.AddWithValue("@StorageType", storage.StorageType);
            cmd.Parameters.AddWithValue("@BenchmarkScore", storage.BenchmarkScore);
            cmd.Parameters.AddWithValue("@StorageSequentialRead", storage.StorageSequentialRead);
            cmd.Parameters.AddWithValue("@StorageSequentialWrite", storage.StorageSequentialWrite);
            cmd.Parameters.AddWithValue("@StorageRandomRead", storage.StorageRandomRead);
            cmd.Parameters.AddWithValue("@StorageRandomWrite", storage.StorageRandomWrite);
            cmd.Parameters.AddWithValue("@BestUse", storage.BestUse);
            cmd.Parameters.AddWithValue("@Price", storage.Price);

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
        /// Retrieves all storage objects.
        /// </summary>
        /// <returns>Lsit of storage objects.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<Storage> RetrieveAllStorage()
        {
           var storage = new List<Storage>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_storage";
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
                        storage.Add(new Storage()
                        {
                            StorageId = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            StorageSize = reader.GetInt32(3),
                            StorageType = reader.GetString(4),
                            BenchmarkScore = reader.GetInt32(5),
                            StorageSequentialRead = reader.GetInt32(6),
                            StorageSequentialWrite = reader.GetInt32(7),
                            StorageRandomRead = reader.GetInt32(8),
                            StorageRandomWrite = reader.GetInt32(9),
                            BestUse = reader.GetString(10),
                            Price = reader.GetDecimal(11)
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
            return storage;
        }
    }
}
