using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Authy.Net.Models
{
    /// <summary>
    /// The result of a request to get user status
    /// </summary>
    public class UserStatusResult : AuthyResult
    {
        [JsonProperty("status")]
        public UserStatusResultDto UserStatus;
    }

    public class UserStatusResultDto
    {
        /// <summary>
        /// The user id of the user
        /// </summary>
        [JsonProperty("authy_id")]
        public string UserId { get; set; }

        /// <summary>
        /// True when the user has used a valid code before.
        /// </summary>
        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        /// <summary>
        /// True when the Authy Mobile/Desktop App was registered.
        /// </summary>
        [JsonProperty("registered")]
        public bool Registered { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Last 4 digits of phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// True when account has hard token.
        /// </summary>
        [JsonProperty("has_hard_token")]
        public bool HasHardToken { get; set; }

        /// <summary>
        /// True when account is disabled
        /// </summary>
        [JsonProperty("account_disabled")]
        public bool AccountDisabled { get; set; }

        /// <summary>
        /// The devices connected to the account
        /// </summary>
        [JsonProperty("devices")]
        public List<string> Devices { get; set; }

        /// <summary>
        /// Detailed device information
        /// </summary>
        [JsonProperty("detailed_devices")]
        public List<Dictionary<string, JToken>> DetailedDevices { get; set; }
    }
}
