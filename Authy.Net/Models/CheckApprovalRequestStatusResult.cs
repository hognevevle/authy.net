using System.Collections.Generic;
using Newtonsoft.Json;

namespace Authy.Net.Models
{
    /// <summary>
    /// The result of a request to create a new approval request
    /// </summary>
    public class CheckApprovalRequestStatusResult : AuthyResult
    {
        /// <summary>
        /// The user id of a succesful registration event
        /// </summary>
        [JsonProperty("approval_request")]
        public ApprovalRequestStatusDto ApprovalRequest { get; set; }
    }

    public class ApprovalRequestStatusDto
    {
        /// <summary>
        /// The user id
        /// </summary>
        [JsonProperty("authy_id")]
        public string UserId { get; set; }

        [JsonProperty("device_uuid")]
        public string DeviceUuid { get; set; }

        [JsonProperty("callback_action")]
        public string CallbackAction { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processed_at")]
        public string ProcessedAt { get; set; }

        [JsonProperty("seconds_to_expire")]
        public string SecondsToExpire { get; set; }

        [JsonProperty("expiration_timestamp")]
        public string ExpirationTimestamp { get; set; }

        [JsonProperty("logos")]
        public string Logos { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public Dictionary<string,string> Details { get; set; }

        [JsonProperty("hidden_details")]
        public Dictionary<string, string> HiddenDetails { get; set; }

        [JsonProperty("user_id")]
        public string UserUuid { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
