using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessObjects;
using DataAccess;


namespace BusinessLogic
{
    /// <summary>
    /// User manager with the job of talking to the database for user fields.
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// Gets the user list for all active users.
        /// </summary>
        /// <param name="group">The group.</param>
        /// <returns>List of Users.</returns>
        /// <exception cref="System.ApplicationException">No records found.</exception>
        public List<User> GetUserList(Active group)
        {
            try
            {
                var userList = UserAccessor.FetchUserList(group);

                if (userList.Count > 0)
                {
                    return userList;
                }
                else
                {
                    throw new ApplicationException("No records found.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user count for all active users.
        /// </summary>
        /// <param name="group">The active status. Defaults to active if no value is passed.</param>
        /// <returns>Count of active users.</returns>
        public int GetUserCount(Active group = Active.active)
        {
            try
            {
                return UserAccessor.FetchUserCount(group);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds a new user.
        /// </summary>
        /// <param name="usr">The user to be added.</param>
        /// <returns>Boolean result of the insert.</returns>
        public bool AddNewUser(User usr)
        {
            try
            {
                if (UserAccessor.InsertUser(usr) == 1)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        /// <summary>
        /// Updates the user information.
        /// </summary>
        /// <param name="usr">The user to be updated.</param>
        /// <returns>Boolean result of the update.</returns>
        /// <exception cref="System.ApplicationException">
        /// Invalid userID
        /// or
        /// First name is too long. Maximum 50 characters.
        /// or
        /// Last name is too long.' Maximum 50 characters.
        /// or
        /// Address is too long.' Maximum 50 characters.
        /// or
        /// City name is too long.' Maximum 50 characters.
        /// or
        /// User name is too long.' Maximum 50 characters.
        /// or
        /// Email address is too long. Maximun 100 characters.
        /// </exception>
        public bool UpdateUserInformation(User usr)
        {
            if (usr.UserID < 1000)
            {
                throw new ApplicationException("Invalid userID");
            }

            if (usr.FirstName.Length > 50)
            {
                throw new ApplicationException("First name is too long. Maximum 50 characters.");
            }
            if (usr.LastName.Length > 50)
            {
                throw new ApplicationException("Last name is too long.' Maximum 50 characters.");
            }
            if (usr.Address.Length > 50)
            {
                throw new ApplicationException("Address is too long.' Maximum 50 characters.");
            }
            if (usr.City.Length > 50)
            {
                throw new ApplicationException("City name is too long.' Maximum 50 characters.");
            }
            if (usr.UserName.Length > 50)
            {
                throw new ApplicationException("User name is too long.' Maximum 50 characters.");
            }
            if (usr.EmailAddress.Length > 100)
            {
                throw new ApplicationException("Email address is too long. Maximun 100 characters.");
            }

            try
            {
                if (UserAccessor.UpdateUserAccount(usr) == 1)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }
    }
}
