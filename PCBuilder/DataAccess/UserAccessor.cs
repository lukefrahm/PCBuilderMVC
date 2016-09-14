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
    /// Data access class that handles data connections with the Users table.
    /// </summary>
    public class UserAccessor
    {
        /// <summary>
        /// Retrieves the user by username.
        /// </summary>
        /// <param name="userName">The username from which to retrieve user data.</param>
        /// <returns>User object from the supplied username.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static User RetrieveUserByUsername(string userName)
        {
            User user = new User();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_select_user_with_username";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", userName);

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    user = new User()
                    {
                        UserID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Address = reader.GetString(3),
                        City = reader.GetString(4),
                        State = reader.GetString(5),
                        Zip = reader.GetString(6),
                        LocalPhone = reader.GetString(7),
                        EmailAddress = reader.GetString(8),
                        UserName = reader.GetString(9),
                        Password = reader.GetString(10),
                        Role = reader.GetString(11),
                        Active = reader.GetBoolean(12),
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
            return user;
        }

        /// <summary>
        /// Retrieves the roles by user identifier.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>List of roles for the username provided.</returns>
        /// <exception cref="System.ApplicationException">Data not found.</exception>
        public static List<Roles> RetrieveRolesByUserID(string username)
        {
            var roles = new List<Roles>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_select_roles_for_username";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roles.Add(new Roles()
                        {
                            Role = reader.GetString(0)
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
            return roles;
        }

        /// <summary>
        /// Finds the user by username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>Row count to signify success or failure.</returns>
        public static int FindUserByUsernameAndPassword(string username, string password)
        {
            int count = 0;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_validate_active_username_and_password";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
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
        /// Sets the password for the given username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="oldPassword">The old password.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns>Row count to signify success or failure.</returns>
        public static int SetPasswordForUsername(string username, string oldPassword, string newPassword)
        {
            int count = 0;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_update_password_for_username";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
            cmd.Parameters.AddWithValue("@newPassword", newPassword);

            try
            {
                conn.Open();
                count = (int)cmd.ExecuteNonQuery();
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
        /// Fetches a user list.
        /// </summary>
        /// <param name="group">The group of users. Defaults to active users only.</param>
        /// <returns>List of Users</returns>
        public static List<User> FetchUserList(Active group = Active.active)
        {
            var users = new List<User>();
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_get_all_users";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Active", group);

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new User()
                        {
                            UserID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Address = reader.GetString(3),
                            City = reader.GetString(4),
                            State = reader.GetString(5),
                            Zip = reader.GetString(6),
                            LocalPhone = reader.GetString(7),
                            EmailAddress = reader.GetString(8),
                            UserName = reader.GetString(9),
                            Password = reader.GetString(10),
                            Role = reader.GetString(11),
                            Active = reader.GetBoolean(12)
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
            return users;
        }

        /// <summary>
        /// Fetches the user count.
        /// </summary>
        /// <param name="group">The active status. Defaults to active if no value is passed.</param>
        /// <returns>Count of records.</returns>
        public static int FetchUserCount(Active group = Active.active)
        {
            int count = 0;
            var conn = DBConnection.GetDBConnection();

            string query = @"sp_get_user_count";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Active", group);

            try
            {
                conn.Open();

                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }

            return count;
        }

        /// <summary>
        /// Inserts a new user.
        /// </summary>
        /// <param name="usr">The user.</param>
        /// <returns>Count of records affected.</returns>
        public static int InsertUser(User usr)
        {
            int count = 0;
            var conn = DBConnection.GetDBConnection();
            var query = @"sp_insert_user";
            var cmd = new SqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", usr.FirstName);
            cmd.Parameters.AddWithValue("@LastName", usr.LastName);
            cmd.Parameters.AddWithValue("@Address", usr.Address);
            cmd.Parameters.AddWithValue("@City", usr.City);
            cmd.Parameters.AddWithValue("@StateCode", usr.State);
            cmd.Parameters.AddWithValue("@Zip", usr.Zip);
            cmd.Parameters.AddWithValue("@LocalPhone", usr.LocalPhone);
            cmd.Parameters.AddWithValue("@EmailAddress", usr.EmailAddress);
            cmd.Parameters.AddWithValue("@Username", usr.UserName);
            cmd.Parameters.AddWithValue("@Password", usr.Password);
            cmd.Parameters.AddWithValue("@RoleName", "Registered");
            cmd.Parameters.AddWithValue("@Active", true);

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
        /// Updates the user account.
        /// </summary>
        /// <param name="usr">The user.</param>
        /// <returns>Count of records updated.</returns>
        public static int UpdateUserAccount(User usr)
        {
            int rowCount = 0;
            var conn = DBConnection.GetDBConnection();
            string cmdText = "sp_update_user_email";
            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", usr.FirstName);
            cmd.Parameters.AddWithValue("@LastName", usr.LastName);
            cmd.Parameters.AddWithValue("@Address", usr.Address);
            cmd.Parameters.AddWithValue("@City", usr.City);
            cmd.Parameters.AddWithValue("@StateCode", usr.State);
            cmd.Parameters.AddWithValue("@Zip", usr.Zip);
            cmd.Parameters.AddWithValue("@LocalPhone", usr.LocalPhone);
            cmd.Parameters.AddWithValue("@EmailAddress", usr.EmailAddress);
            cmd.Parameters.AddWithValue("@Username", usr.UserName);
            cmd.Parameters.AddWithValue("@Password", usr.Password);
            cmd.Parameters.AddWithValue("@RoleName", usr.Role);
            cmd.Parameters.AddWithValue("@Active", usr.Active);

            try
            {
                conn.Open();

                rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rowCount;
        }

    }
}
