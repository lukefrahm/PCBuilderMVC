using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// User object to hold necessary data on users.
    /// </summary>
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string LocalPhone { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="localPhone">The local phone.</param>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="userName">Username for the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="active">if set to <c>true</c>, [active].</param>
        /// <param name="role">The role.</param>
        public User(int userID,
                    string firstName,
                    string lastName,
                    string address,
                    string city,
                    string state,
                    string zip,
                    string localPhone,
                    string emailAddress,
                    string userName,
                    string password,
                    bool active,
                    string role)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            LocalPhone = localPhone;
            EmailAddress = emailAddress;
            UserName = userName;
            Password = password;
            Active = active;
            Role = role;
        }
    }
}
