using System.Collections.Generic;
using Newtonsoft.Json;

namespace Authy.Net.Models
{
    /// <summary>
    /// A base authy result
    /// </summary>
    public class AuthyResult
    {
        /// <summary>
        /// The status of a request
        /// </summary>
        [JsonIgnore]
        public AuthyStatus Status { get; set; }

        /// <summary>
        /// The raw response returned from the API
        /// </summary>
        public string RawResponse { get; set; }

        /// <summary>
        /// The request was success
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The message from the API
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The error code from the API
        /// </summary>

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The list of erros
        /// <summary>
        public Dictionary<string, string> Errors { get; set; }
    }
}
