using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using Authy.Net.Helpers;
using Authy.Net.Models;

namespace Authy.Net
{
    /// <summary>
    /// Client for interacting with the Authy API
    /// </summary>
    /// <remarks>
    /// This library is threadsafe since the only shared state is stored in private readonly fields.
    ///
    /// Creating a single instance of the client and using it across multiple threads isn't a problem.
    /// </remarks>
    public class AuthyClient
    {
        private readonly string _apiKey;

        private static string BaseUrl => "https://api.authy.com";

        /// <summary>
        /// Creates an instance of the Authy client
        /// </summary>
        /// <param name="apiKey">The api key used to access the rest api</param>
        public AuthyClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Register a user
        /// </summary>
        /// <param name="email">Email address</param>
        /// <param name="cellPhoneNumber">Cell phone number</param>
        /// <param name="countryCode">Country code</param>
        /// <returns>RegisterUserResult object containing the details about the attempted register user request</returns>
        /// <exception cref="AuthyInvalidPhoneNumberException">If the phone number is invalid.</exception>
        /// <exception cref="AuthyInvalidEmailException">If the email is invalid.</exception>
        /// <exception cref="AuthyInvalidCountryCodeException">If the country code is invalid.</exception>
        public RegisterUserResult RegisterUser(string email, string cellPhoneNumber, int countryCode = 1)
        {
            var request = new NameValueCollection()
            {
                {"user[email]", email},
                {"user[cellphone]",cellPhoneNumber},
                {"user[country_code]",countryCode.ToString()}
            };

            var url = string.Format("{0}/protected/json/users/new?api_key={1}", BaseUrl, _apiKey);
            return Execute(client =>
            {
                var response = client.UploadValues(url, request);
                var textResponse = Encoding.ASCII.GetString(response);

                var apiResponse = JsonConvert.DeserializeObject<RegisterUserResult>(textResponse);
                apiResponse.RawResponse = textResponse;
                apiResponse.Status = AuthyStatus.Success;
                apiResponse.UserId = apiResponse.User["id"];

                return apiResponse;
            });
        }

        /// <summary>
        /// Get user status
        /// </summary>
        /// <param name="userId">The user for which you would like to get status</param>
        /// <returns>RegisterUserResult object containing the details about the attempted register user request</returns>
        public UserStatusResult GetUserStatus(string userId)
        {
            var url = string.Format("{0}/protected/json/users/{1}/status?api_key={2}", BaseUrl, userId, _apiKey);

            return Execute(client =>
            {
                var response = client.DownloadString(url);

                var apiResponse = JsonConvert.DeserializeObject<UserStatusResult>(response);
                apiResponse.RawResponse = response;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        /// <summary>
        /// Get user status
        /// </summary>
        /// <param name="userId">The user for which you would like to get status</param>
        /// <returns>RegisterUserResult object containing the details about the attempted register user request</returns>
        public AuthyResult DeleteUser(string userId)
        {
            var url = string.Format("{0}/protected/json/users/{1}/delete", BaseUrl, userId);

            return Execute(client =>
            {
                client.Headers.Add("X-Authy-API-Key", _apiKey);
                var response = client.UploadString(url, "");

                var apiResponse = JsonConvert.DeserializeObject<AuthyResult>(response);
                apiResponse.RawResponse = response;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        /// <summary>
        /// Verify a token with Authy
        /// </summary>
        /// <param name="userId">The Authy user id</param>
        /// <param name="token">The token to verify</param>
        /// <param name="force">Force verification to occur even if the user isn't registered (if the user hasn't finished registering the default is to succesfully validate)</param>
        /// <exception cref="AuthyTokenInvalidException">Token was invalid.</exception>
        /// <exception cref="AuthyTokenReusedException">Token is already used.</exception>
        /// <exception cref="AuthyUserNotFoundException">User was not found.</exception>

        public VerifyTokenResult VerifyToken(string userId, string token, bool force = false)
        {
            if (!AuthyHelpers.TokenIsValid(token))
            {
                throw new AuthyTokenInvalidException($"Token '{token}' is invalid.");
            }

            token = AuthyHelpers.SanitizeNumber(token);
            userId = AuthyHelpers.SanitizeNumber(userId);

            var url = string.Format("{0}/protected/json/verify/{1}/{2}?api_key={3}{4}", BaseUrl, token, userId, _apiKey, force ? "&force=true" : string.Empty);

            return Execute(client =>
            {
                var response = client.DownloadString(url);

                var apiResponse = JsonConvert.DeserializeObject<VerifyTokenResult>(response);

                if (apiResponse.Token == "is valid")
                {
                    apiResponse.Status = AuthyStatus.Success;
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Status = AuthyStatus.Unauthorized;
                }

                apiResponse.RawResponse = response;

                return apiResponse;
            });
        }

        /// <summary>
        /// Send an SMS message to a user who isn't registered.  If the user is registered with a mobile app then no message will be sent.
        /// </summary>
        /// <param name="userId">The user ID to send the message to</param>
        /// <param name="force">Force a message to be sent even if the user is already registered as an app user. This will incrase your costs</param>
        public SendSmsResult SendSms(string userId, bool force = false)
        {
            userId = AuthyHelpers.SanitizeNumber(userId);

            var url = string.Format("{0}/protected/json/sms/{1}?api_key={2}{3}", BaseUrl, userId, _apiKey, force ? "&force=true" : string.Empty);
            
            return Execute(client =>
            {
                var response = client.DownloadString(url);

                var apiResponse = JsonConvert.DeserializeObject<SendSmsResult>(response);
                apiResponse.Status = AuthyStatus.Success;
                apiResponse.RawResponse = response;

                return apiResponse;
            });
        }

        /// <summary>
        /// Send the token via phone call to a user who isn't registered.  If the user is registered with a mobile app then the phone call will be ignored.
        /// </summary>
        /// <param name="userId">The user ID to send the phone call to</param>
        /// <param name="force">Force to the phone call to be sent even if the user is already registered as an app user. This will incrase your costs</param>
        public AuthyResult StartPhoneCall(string userId, bool force = false)
        {
            userId = AuthyHelpers.SanitizeNumber(userId);

            var url = string.Format("{0}/protected/json/call/{1}?api_key={2}{3}", BaseUrl, userId, _apiKey, force ? "&force=true" : string.Empty);

            return Execute(client =>
            {
                var response = client.DownloadString(url);

                var apiResponse = JsonConvert.DeserializeObject<AuthyResult>(response);
                apiResponse.Status = AuthyStatus.Success;
                apiResponse.RawResponse = response;

                return apiResponse;
            });
        }

        /// <summary>
        /// This will create a new approval request for the given Authy ID and send it to the end user along with a push notification to the Authy smartphone application.
        /// </summary>
        /// <param name="userId">The Authy user id.</param>
        /// <param name="message">Required. The message shown to the user when the approval request arrives.</param>
        /// <param name="details">Dictionary containing the ApprovalRequest details that will be shown to user</param>
        /// <param name="hiddenDetails">Dictionary containing the approval request details hidden to user.</param>
        /// <param name="secondsToExpire">Optional, defaults to 86400 (one day). Number of seconds that the approval request will be available for being responded. 
        /// If set to 0, the approval request won't expire. Expiration time can be set to several months, without affecting security. 
        /// For certain use cases, it might be important to set a short expiration time. However, expiration time should not affect security by enforcing users to act too quickly. 
        /// Instead, the users should be able to take their time to check the details of the approval requests before approving/denying it.</param>
        /// <returns>CreateApprovalRequestResult object containing the uuid for the approval request.</returns>
        public CreateApprovalRequestResult CreateApprovalRequest(string userId, string message, Dictionary<string, string> details, Dictionary<string, string> hiddenDetails, int secondsToExpire = 86400)
        {
            var request = new NameValueCollection()
            {
                {"api_key", _apiKey},
                {"message", message},
                {"seconds_to_expire", secondsToExpire.ToString()}
            };

            if (details != null)
            {
                foreach (var detail in details)
                {
                    request.Add(new NameValueCollection
                    {
                        {$"details[{detail.Key}]", detail.Value}
                    });
                }
            }

            if (hiddenDetails != null)
            {
                foreach (var detail in hiddenDetails)
                {
                    request.Add(new NameValueCollection
                    {
                        {$"hidden_details[{detail.Key}]", detail.Value}
                    });
                }
            }

            var url = string.Format("{0}/onetouch/json/users/{1}/approval_requests", BaseUrl, userId);

            return Execute(client =>
            {
                var response = client.UploadValues(url, request);
                var textResponse = Encoding.ASCII.GetString(response);

                var apiResponse = JsonConvert.DeserializeObject<CreateApprovalRequestResult>(textResponse);
                apiResponse.RawResponse = textResponse;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        /// <summary>
        /// This will create a new approval request for the given Authy ID and send it to the end user along with a push notification to the Authy smartphone application.
        /// </summary>
        /// <param name="uuid">Required. The approval request ID. (Obtained from the response to an ApprovalRequest).</param>
        /// <returns>RegisterUserResult object containing the details about the attempted register user request</returns>
        /// <exception cref="AuthyOneTouchApprovalRequestNotFoundException">Onetouch Approval request not found.</exception>
        /// <exception cref="AuthyOneTouchUnregisteredUserException">Application has not added user.</exception>
        /// <exception cref="AuthyOneTouchDeviceNotFoundException">User does not have OneTouch device for given application.</exception>
        public CheckApprovalRequestStatusResult CheckApprovalRequestStatus(string uuid)
        {
            if (string.IsNullOrEmpty(uuid))
            {
                throw new AuthyOneTouchApprovalRequestNotFoundException("uuid was missing.");
            }

            var url = string.Format("{0}/onetouch/json/approval_requests/{1}?api_key={2}", BaseUrl, uuid, _apiKey);

            return Execute(client =>
            {
                var response = client.DownloadString(url);
                var apiResponse = JsonConvert.DeserializeObject<CheckApprovalRequestStatusResult>(response);
                apiResponse.RawResponse = response;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        /// <summary>
        /// This will request a verification code to be sent to a phone number. The verification code is valid for 10 minutes. Subsequent calls to the API within the expiration time will send the same verification code.
        /// </summary>
        /// <param name="via">Either "sms" or "call".</param>
        /// <param name="phoneNumber">The phone number to send the verification code.</param>
        /// <param name="countryCode">The phone's country code.</param>
        /// <param name="locale">The phone's country code.
        /// The language of the message received by user. If no locale is given, Authy will try to autodetect it based on the country code. 
        /// In case that no locale is autodetected, English will be used. Supported languages include: English (en), Arabic (ar), Catalan (ca), 
        /// Danish (da), German (de), Spanish (es), Greek (el), Finnish (fi), French (fr) , Hebrew (he), Hindi (hi), Hungarian (hu), Indonesian (id), 
        /// Italian (it), Japanese (ja), Korean (ko), Norwegian (nb), Dutch (nl), Polish (pl), Portuguese (pt), Romanian (ro), Russian (ru), Swedish (sv), 
        /// Thai (th), Tagalog (tl), Turkish (tr), Vietnamese (vi), Mandarin (zh-CN),Cantonese (zh-HK). We support the format country-region as described in 
        /// IETF's BPC 47. If no region is given (or supported), there will be a default by country.
        /// </param>
        /// <param name="codeLength">Optional value to change the number of verification digits sent. Default is 4. Allowed values are 4-10.</param>
        /// <param name="customMessage">
        /// Not available by default. Overwrites the default message sent sms or phone call. To request access please contact Authy sales with a business use 
        /// case that requires a nonstandard message. You can inject a phone verification code in the message by using the string {{code}} were you'd like to 
        /// insert it. IMPORTANT: If the via parameter is set to "call", the locale parameter is mandatory. The following languages are supported for call 
        /// custom_messages: English (en), Spanish (es), Portuguese (pt), German (de), French (fr),Italian (it), Daniesh (da),German (de),Finish (fi), Japanese (ja), 
        /// Korean (ko), Norwegian (nb), Deutch (nl), Polish (pl), Russian (ru), Swedish (sv), Mandarin (zh-CN),Cantonese (zh-HK). We support the format country-region as 
        /// described in IETF's BPC 47. If no region is given (or supported), there will be a default by country.
        /// </param>
        /// <returns>The response will include the carrier, whether the number is a cellphone or not, the verification code expiration time, the request UUID and the request status.</returns>
        /// <exception cref="AuthyInvalidPhoneNumberException">If the phone number is invalid.</exception>
        /// <exception cref="AuthyPhoneVerificationCouldNotBeCreatedException">If an error occured when initiating the verification. Check your input data.</exception>
        /// <exception cref="AuthyInvalidCountryCodeException">If the country code is invalid.</exception>
        public PhoneVerificationRequestResult RequestPhoneVerification(string via, string phoneNumber, int countryCode, string locale = null, int? codeLength = null, string customMessage = null)
        {
            var request = new NameValueCollection()
            {
                {"api_key", _apiKey},
                {"via", via},
                {"country_code", countryCode.ToString()},
                {"phone_number", phoneNumber}
            };

            if (locale != null)
            {
                request.Add(new NameValueCollection
                {
                    {"locale", locale}
                });
            }

            if (codeLength != null)
            {
                request.Add(new NameValueCollection
                {
                    {"code_length", codeLength.ToString()}
                });
            }

            if (customMessage != null)
            {
                request.Add(new NameValueCollection
                {
                    {"custom_message", customMessage}
                });
            }

            var url = string.Format("{0}/protected/json/phones/verification/start", BaseUrl);

            return Execute(client =>
            {
                var response = client.UploadValues(url, request);
                var textResponse = Encoding.ASCII.GetString(response);

                var apiResponse = JsonConvert.DeserializeObject<PhoneVerificationRequestResult>(textResponse);
                apiResponse.RawResponse = textResponse;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        /// <summary>
        /// Verify a phone verification code previously sent to the user
        /// </summary>
        /// <param name="phoneNumber">The phone number where the verification code was sent.</param>
        /// <param name="countryCode"></param>
        /// <param name="verificationCode">The verification code that is being validated.</param>
        /// <returns>RegisterUserResult object containing the details about the attempted register user request</returns>
        /// <exception cref="AuthyVerificationCodeIsIncorrectException">If the code is invalid.</exception>
        /// <exception cref="AuthyInvalidPhoneNumberException">If the phone number is invalid.</exception>
        /// <exception cref="AuthyPhoneVerificationNotFoundException">If no verification request for the provided number exists, or request has expired.</exception>
        /// <exception cref="AuthyInvalidCountryCodeException">If the country code is invalid.</exception>
        public PhoneVerificationCheckResult VerifyPhoneVerification(string phoneNumber, int countryCode, string verificationCode)
        {
            var url = string.Format("{0}/protected/json/phones/verification/check?api_key={1}&country_code={2}&phone_number={3}&verification_code={4}", 
                BaseUrl, _apiKey, countryCode, phoneNumber, verificationCode);

            return Execute(client =>
            {
                var response = client.DownloadString(url);
                var apiResponse = JsonConvert.DeserializeObject<PhoneVerificationCheckResult>(response);
                apiResponse.RawResponse = response;
                apiResponse.Status = AuthyStatus.Success;

                return apiResponse;
            });
        }

        private TResult Execute<TResult>(Func<WebClient, TResult> execute)
            where TResult : AuthyResult, new()
        {
            var client = new WebClient();
            var libraryVersion = AuthyHelpers.GetVersion();
            var runtimeVersion = AuthyHelpers.GetSystemInfo();
            var userAgent = string.Format("AuthyNet/{0} ({1})", libraryVersion, runtimeVersion);

            // Set a custom user agent
            client.Headers.Add("user-agent", userAgent);

            try
            {
                return execute(client);
            }
            catch (WebException webex)
            {
                var response = webex.Response.GetResponseStream();

                if (response == null)
                {
                    throw new AuthyNullResponseException(null);
                }

                string body;
                using (var reader = new StreamReader(response))
                {
                    body = reader.ReadToEnd();
                }

                var result = JsonConvert.DeserializeObject<TResult>(body);

                if (result.ErrorCode != null)
                {
                    ErrorHelper.CheckErrorCodeAndThrow(result.ErrorCode, result.Message);
                }

                switch (((HttpWebResponse)webex.Response).StatusCode)
                {
                    case HttpStatusCode.ServiceUnavailable:
                        result.Status = AuthyStatus.ServiceUnavailable;
                        break;
                    case HttpStatusCode.Unauthorized:
                        result.Status = AuthyStatus.Unauthorized;
                        break;
                    default:
                    case HttpStatusCode.BadRequest:
                        result.Status = AuthyStatus.BadRequest;
                        break;
                }
                return result;
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
