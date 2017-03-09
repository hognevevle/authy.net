using Newtonsoft.Json;

namespace Authy.Net.Models
{
    /// <summary>
    /// The result of a request to create a new approval request
    /// </summary>
    public class CreateApprovalRequestResult : AuthyResult
    {
        /// <summary>
        /// The user id of a succesful registration event
        /// </summary>
        [JsonProperty("approval_request")]
        public ApprovalRequstDto ApprovalRequest { get; set; }
    }

    public class ApprovalRequstDto
    {
        public string Uuid { get; set; }
    }
}
