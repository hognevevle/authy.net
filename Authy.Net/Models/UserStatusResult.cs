using System.Collections.Generic;

namespace Authy.Net.Models
{
    /// <summary>
    /// The result of a request to get user status
    /// </summary>
    public class UserStatusResult : AuthyResult
    {
        /// <summary>
        /// The user id of a succesful registration event
        /// </summary>
        //public bool status { get; set; }

        /// <summary>
        /// The user information on Authy API
        /// </summary>
        public Dictionary<string, string> User { get; set;}
    }
}
