using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObjects;

namespace BusinessLogic
{
    /// <summary>
    /// Class tasked with maintaining application security when handling user information.
    /// </summary>
    public class SecurityManager
    {
        const int MIN_USERNAME = 5;
        const int MIN_PASSWORD = 5;

        /// <summary>
        /// Validates an existing user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>AccessToken used to keep validated information for processing.</returns>
        /// <exception cref="System.ApplicationException">
        /// Password and username must be between 5 and 50 characters.
        /// or
        /// Data not found.
        /// </exception>
        public static AccessToken ValidateExistingUser(string username, string password)
        {
            AccessToken accessToken;

            if (username.Length < MIN_USERNAME || password.Length < MIN_PASSWORD)
            {
                throw new ApplicationException("Password and username must be between 5 and 50 characters.");
            }

            try
            {
                if (1 == UserAccessor.FindUserByUsernameAndPassword(username, password.HashSha256()))
                {
                    var usr = UserAccessor.RetrieveUserByUsername(username);
                    usr.UserName = username;
                    var roles = UserAccessor.RetrieveRolesByUserID(username);
                    accessToken = new AccessToken(usr, roles);
                }
                else
                {
                    throw new ApplicationException("Data not found.");
                }
            }
            catch
            {
                throw;
            }
            return accessToken;
        }

        /// <summary>
        /// Validates a new user.
        /// </summary>
        /// <param name="usr">The user.</param>
        /// <returns>AccessToken used to keep validated information for processing.</returns>
        /// <exception cref="System.ApplicationException">User already exists!</exception>
        public static AccessToken ValidateNewUser(User usr)
        {
            string oldPassw;
            if (0 == UserAccessor.FindUserByUsernameAndPassword(usr.UserName, usr.Password.HashSha256()))
            {
                oldPassw = usr.Password;
                usr.Password = usr.Password.HashSha256();
                UserAccessor.InsertUser(usr);
            }
            else
            {
                throw new ApplicationException("User already exists!");
            }

            return ValidateExistingUser(usr.UserName, oldPassw);
        }

    }
}
