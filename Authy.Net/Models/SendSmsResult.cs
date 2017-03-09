namespace Authy.Net.Models
{
    /// <summary>
    /// Result from sending an SMS
    /// </summary>
    public class SendSmsResult : AuthyResult
    {
        /// <summary>
        /// The cell phone number
        /// </summary>
        public string Cellphone { get; set; }

        /// <summary>
        /// The name of the most recent device used by the user. This is only returned when the SMS was ignored.
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// True if the SMS was ignored, thus not sent.
        /// </summary>
        public bool Ignored { get; set; }
    }
}
