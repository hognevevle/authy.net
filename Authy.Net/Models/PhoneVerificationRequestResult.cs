using Newtonsoft.Json;

namespace Authy.Net.Models
{
    /// <summary>
    /// Result from starting a phone verification process.
    /// </summary>
    public class PhoneVerificationRequestResult : AuthyResult
    {
        /// <summary>
        /// The carrier
        /// </summary>
        public string Carrier { get; set; }

        /// <summary>
        /// Whether the phone number was ported or not.
        /// </summary>
        [JsonProperty("is_ported")]
        public bool IsPorted { get; set; }

        /// <summary>
        /// Whether the phone number is a cellphone or not.
        /// </summary>
        [JsonProperty("is_cellphone")]
        public bool IsCellphone { get; set; }
    }
}

