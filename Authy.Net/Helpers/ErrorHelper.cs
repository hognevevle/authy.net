namespace Authy.Net.Helpers
{
    /// <summary>
    /// Error helper class
    /// </summary>
    public static class ErrorHelper
    {
        /// <summary>
        /// Looks up the error code and throws corresponding exception.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <exception cref="AuthyGeneralErrorException"></exception>
        /// <exception cref="AuthyInvalidApiKeyException"></exception>
        /// <exception cref="AuthyInvalidRequestException"></exception>
        /// <exception cref="AuthyDosProtectionException"></exception>
        /// <exception cref="AuthyInvalidParameterException"></exception>
        /// <exception cref="AuthyInvalidUtf8Exception"></exception>
        /// <exception cref="AuthyPhoneCallsNotEnabledException"></exception>
        /// <exception cref="AuthySmsNotEnabledException"></exception>
        /// <exception cref="AuthySuspendedAccountException"></exception>
        /// <exception cref="AuthyExceededMonthlySmsLimitException"></exception>
        /// <exception cref="AuthyExceededDailySmsLimitException"></exception>
        /// <exception cref="AuthyExceededMonthlyPhoneCallLimitException"></exception>
        /// <exception cref="AuthyExceededDailyPhoneCallLimitException"></exception>
        /// <exception cref="AuthyBannedCountryCodeException"></exception>
        /// <exception cref="AuthyCallNotStartedException"></exception>
        /// <exception cref="AuthySmsTokenNotSentException"></exception>
        /// <exception cref="AuthyUserNotFoundException"></exception>
        /// <exception cref="AuthyUserSuspendedException"></exception>
        /// <exception cref="AuthyUserDisabledException"></exception>
        /// <exception cref="AuthyTokenReusedException"></exception>
        /// <exception cref="AuthyTokenInvalidException"></exception>
        /// <exception cref="AuthyPhoneVerificationCouldNotBeCreatedException"></exception>
        /// <exception cref="AuthyVerificationCodeIsIncorrectException"></exception>
        /// <exception cref="AuthyPhoneVerificationNotFoundException"></exception>
        /// <exception cref="AuthyCouldNotGetPhoneInformationException"></exception>
        /// <exception cref="AuthyPhoneInformationQueryServerErrorException"></exception>
        /// <exception cref="AuthyInvalidUserException"></exception>
        /// <exception cref="AuthyUserCannotBeDeletedException"></exception>
        /// <exception cref="AuthyActivityCouldNotBeCreatedException"></exception>
        /// <exception cref="AuthyIncorrectUserParamsException"></exception>
        /// <exception cref="AuthyActionNotAuthorizedException"></exception>
        /// <exception cref="AuthySmsNotFoundException"></exception>
        /// <exception cref="AuthyInvalidPhoneNumberException"></exception>
        /// <exception cref="AuthyInvalidRegistrationRequestException"></exception>
        /// <exception cref="AuthyRegistrationRequestNotFoundException"></exception>
        /// <exception cref="AuthyInvalidRegistrationPinException"></exception>
        /// <exception cref="AuthyRegistrationRequestExpiredException"></exception>
        /// <exception cref="AuthyInvalidEmailException"></exception>
        /// <exception cref="AuthyUuidOrCountryCodeAndPhoneNumberRequiredException"></exception>
        /// <exception cref="AuthyMissingDashboardAccountIdsException"></exception>
        /// <exception cref="AuthyOneTouchApprovalRequestNotFoundException"></exception>
        /// <exception cref="AuthyOneTouchUnregisteredUserException"></exception>
        /// <exception cref="AuthyOneTouchDeviceNotFoundException"></exception>
        /// <exception cref="AuthyApprovalRequestFailedException"></exception>
        /// <exception cref="AuthyApprovalRequestNotPendingException"></exception>
        /// <exception cref="AuthyCustomerNotificationFailedException"></exception>
        /// <exception cref="AuthyHttpsRequiredException"></exception>
        /// <exception cref="AuthyAccountTemporarilySuspendedException"></exception>
        /// <exception cref="AuthyPhoneNumberNotFoundException"></exception>
        /// <exception cref="AuthyAccountSuspendedException"></exception>
        /// <exception cref="AuthyApplicationSuspendedException"></exception>
        /// <exception cref="AuthyDisallowedIpAddressException"></exception>
        /// <exception cref="AuthyOneTouchEnableFailedException"></exception>
        /// <exception cref="AuthyOneTouchMustBeEnabledException"></exception>
        /// <exception cref="AuthyCallbackInformationSaveFailedException"></exception>
        /// <exception cref="AuthyAccessBlockedForMultiDeviceUser"></exception>
        /// <exception cref="AuthyRegistrationDeviceUpdateFailedException"></exception>
        /// <exception cref="AuthyAccessKeyCanNotBeSavedException"></exception>
        /// <exception cref="AuthyInvalidApplicationException"></exception>
        /// <exception cref="AuthyAccessKeyNotFoundException"></exception>
        /// <exception cref="AuthyInvalidAccessKeyException"></exception>
        /// <exception cref="AuthyInvalidApplicationApiKeyException"></exception>
        /// <exception cref="AuthyAccessKeyInsufficientPermissionsException"></exception>
        /// <exception cref="AuthyApplicationCouldNotBeDeletedException"></exception>
        /// <exception cref="AuthyInvalidCountryCodeException"></exception>
        /// <exception cref="AuthyInvalidApprovalRequest"></exception>
        /// <exception cref="AuthyLandLineSmsNotAllowedException"></exception>
        /// <exception cref="AuthyPhoneNumberNotProvisionedWithAnyCarrierException"></exception>
        /// <exception cref="AuthyOneTouchNotEnabledException"></exception>
        /// <exception cref="AuthyUnknownErrorException"></exception>
        public static void CheckErrorCodeAndThrow(string errorCode, string message)
        {
            switch (errorCode)
            {
                case "60000": throw new AuthyGeneralErrorException(message);
                case "60001": throw new AuthyInvalidApiKeyException(message);
                case "60002": throw new AuthyInvalidRequestException(message);
                case "60003": throw new AuthyDosProtectionException(message);
                case "60004": throw new AuthyInvalidParameterException(message);
                case "60005": throw new AuthyInvalidUtf8Exception(message);
                case "60006": throw new AuthyPhoneCallsNotEnabledException(message);
                case "60007": throw new AuthySmsNotEnabledException(message);
                case "60008": throw new AuthySuspendedAccountException(message);
                case "60009": throw new AuthyExceededMonthlySmsLimitException(message);
                case "60010": throw new AuthyExceededDailySmsLimitException(message);
                case "60011": throw new AuthyExceededMonthlyPhoneCallLimitException(message);
                case "60012": throw new AuthyExceededDailyPhoneCallLimitException(message);
                case "60013": throw new AuthyBannedCountryCodeException(message);
                case "60014": throw new AuthyCallNotStartedException(message);
                case "60015": throw new AuthySmsTokenNotSentException(message);
                case "60016": throw new AuthyUserNotFoundException(message);
                case "60017": throw new AuthyUserSuspendedException(message);
                case "60018": throw new AuthyUserDisabledException(message);
                case "60019": throw new AuthyTokenReusedException(message);
                case "60020": throw new AuthyTokenInvalidException(message);
                case "60021": throw new AuthyPhoneVerificationCouldNotBeCreatedException(message);
                case "60022": throw new AuthyVerificationCodeIsIncorrectException(message);
                case "60023": throw new AuthyPhoneVerificationNotFoundException(message);
                case "60024": throw new AuthyCouldNotGetPhoneInformationException(message);
                case "60025": throw new AuthyPhoneInformationQueryServerErrorException(message);
                case "60026": throw new AuthyUserNotFoundException(message);
                case "60027": throw new AuthyInvalidUserException(message);
                case "60028": throw new AuthyUserCannotBeDeletedException(message);
                case "60029": throw new AuthyActivityCouldNotBeCreatedException(message);
                case "60030": throw new AuthyIncorrectUserParamsException(message);
                case "60031": throw new AuthyActionNotAuthorizedException(message);
                case "60032": throw new AuthySmsNotFoundException(message);
                case "60033": throw new AuthyInvalidPhoneNumberException(message);
                case "60034": throw new AuthyInvalidRegistrationRequestException(message);
                case "60035": throw new AuthyRegistrationRequestNotFoundException(message);
                case "60036": throw new AuthyInvalidRegistrationPinException(message);
                case "60037": throw new AuthyRegistrationRequestExpiredException(message);
                case "60038": throw new AuthyInvalidEmailException(message);
                case "60042": throw new AuthyUuidOrCountryCodeAndPhoneNumberRequiredException(message);
                case "60046": throw new AuthyMissingDashboardAccountIdsException(message);
                case "60047": throw new AuthyInvalidApiKeyException(message);
                case "60049": throw new AuthyOneTouchApprovalRequestNotFoundException(message);
                case "60050": throw new AuthyOneTouchUnregisteredUserException(message);
                case "60051": throw new AuthyOneTouchDeviceNotFoundException(message);
                case "60052": throw new AuthyApprovalRequestFailedException(message);
                case "60053": throw new AuthyApprovalRequestFailedException(message);
                case "60054": throw new AuthyApprovalRequestNotPendingException(message);
                case "60055": throw new AuthyCustomerNotificationFailedException(message);
                case "60056": throw new AuthyHttpsRequiredException(message);
                case "60057": throw new AuthyAccountTemporarilySuspendedException(message);
                case "60058": throw new AuthyPhoneNumberNotFoundException(message);
                case "60059": throw new AuthyInvalidPhoneNumberException(message);
                case "60060": throw new AuthyAccountSuspendedException(message);
                case "60061": throw new AuthyApplicationSuspendedException(message);
                case "60063": throw new AuthyDisallowedIpAddressException(message);
                case "60064": throw new AuthyOneTouchEnableFailedException(message);
                case "60065": throw new AuthyOneTouchMustBeEnabledException(message);
                case "60066": throw new AuthyCallbackInformationSaveFailedException(message);
                case "60067": throw new AuthyAccessBlockedForMultiDeviceUser(message);
                case "60068": throw new AuthyRegistrationDeviceUpdateFailedException(message);
                case "60069": throw new AuthyAccessKeyCanNotBeSavedException(message);
                case "60070": throw new AuthyInvalidApplicationException(message);
                case "60071": throw new AuthyAccessKeyNotFoundException(message);
                case "60072": throw new AuthyInvalidAccessKeyException(message);
                case "60073": throw new AuthyInvalidApplicationApiKeyException(message);
                case "60074": throw new AuthyAccessKeyInsufficientPermissionsException(message);
                case "60075": throw new AuthyApplicationCouldNotBeDeletedException(message);
                case "60078": throw new AuthyInvalidCountryCodeException(message);
                case "60079": throw new AuthyApprovalRequestNotPendingException(message);
                case "60080": throw new AuthyInvalidApprovalRequest(message);
                case "60082": throw new AuthyLandLineSmsNotAllowedException(message);
                case "60083": throw new AuthyPhoneNumberNotProvisionedWithAnyCarrierException(message);
                case "60085": throw new AuthyOneTouchNotEnabledException(message);
                default: throw new AuthyUnknownErrorException(message);
            }
        }
    }
}
