using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// AccessToken object to hold necessary data on the user's authentication and role status.
    /// </summary>
    /// <seealso cref="BusinessObjects.User" />
    public sealed class AccessToken : User
    {
        public List<Roles> Roles { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessToken"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="roles">The roles assigned to the user.</param>
        /// <exception cref="System.ApplicationException">Invalid User.</exception>
        public AccessToken(User user, List<Roles> roles)
        {
            if (user == null || roles == null || roles.Count == 0 )
            {
                throw new ApplicationException("Invalid User");
            }
            base.UserID = user.UserID;
            base.FirstName = user.FirstName;
            base.LastName = user.LastName;
            base.LocalPhone = user.LocalPhone;
            base.EmailAddress = user.EmailAddress;
            base.UserName = user.UserName;
            base.Active = user.Active;

            Roles = roles;
        }
    }

}
