using System;

namespace Authy.Net
{
    public class AuthyException : Exception
    {
        public AuthyException(string message) : base(message)
        {
        }
    }

    public class AuthyNullResponseException : AuthyException
    {
        public AuthyNullResponseException(string message) : base(message)
        {
        }
    }

    public class AuthyUnknownErrorException : AuthyException
    {
        public AuthyUnknownErrorException(string message) : base(message)
        {
        }
    }

    public class AuthyGeneralErrorException : AuthyException
    {
        public AuthyGeneralErrorException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidApiKeyException : AuthyException
    {
        public AuthyInvalidApiKeyException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidRequestException : AuthyException
    {
        public AuthyInvalidRequestException(string message) : base(message)
        {
        }
    }

    public class AuthyDosProtectionException : AuthyException
    {
        public AuthyDosProtectionException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidParameterException : AuthyException
    {
        public AuthyInvalidParameterException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidUtf8Exception : AuthyException
    {
        public AuthyInvalidUtf8Exception(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneCallsNotEnabledException : AuthyException
    {
        public AuthyPhoneCallsNotEnabledException(string message) : base(message)
        {
        }
    }

    public class AuthySmsNotEnabledException : AuthyException
    {
        public AuthySmsNotEnabledException(string message) : base(message)
        {
        }
    }

    public class AuthySuspendedAccountException : AuthyException
    {
        public AuthySuspendedAccountException(string message) : base(message)
        {
        }
    }

    public class AuthyExceededMonthlySmsLimitException : AuthyException
    {
        public AuthyExceededMonthlySmsLimitException(string message) : base(message)
        {
        }
    }

    public class AuthyExceededDailySmsLimitException : AuthyException
    {
        public AuthyExceededDailySmsLimitException(string message) : base(message)
        {
        }
    }

    public class AuthyExceededMonthlyPhoneCallLimitException : AuthyException
    {
        public AuthyExceededMonthlyPhoneCallLimitException(string message) : base(message)
        {
        }
    }

    public class AuthyExceededDailyPhoneCallLimitException : AuthyException
    {
        public AuthyExceededDailyPhoneCallLimitException(string message) : base(message)
        {
        }
    }

    public class AuthyBannedCountryCodeException : AuthyException
    {
        public AuthyBannedCountryCodeException(string message) : base(message)
        {
        }
    }

    public class AuthyCallNotStartedException : AuthyException
    {
        public AuthyCallNotStartedException(string message) : base(message)
        {
        }
    }

    public class AuthySmsTokenNotSentException : AuthyException
    {
        public AuthySmsTokenNotSentException(string message) : base(message)
        {
        }
    }

    public class AuthyUserNotFoundException : AuthyException
    {
        public AuthyUserNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyUserSuspendedException : AuthyException
    {
        public AuthyUserSuspendedException(string message) : base(message)
        {
        }
    }

    public class AuthyUserDisabledException : AuthyException
    {
        public AuthyUserDisabledException(string message) : base(message)
        {
        }
    }

    public class AuthyTokenReusedException : AuthyException
    {
        public AuthyTokenReusedException(string message) : base(message)
        {
        }
    }

    public class AuthyTokenInvalidException : AuthyException
    {
        public AuthyTokenInvalidException(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneVerificationCouldNotBeCreatedException : AuthyException
    {
        public AuthyPhoneVerificationCouldNotBeCreatedException(string message) : base(message)
        {
        }
    }

    public class AuthyVerificationCodeIsIncorrectException : AuthyException
    {
        public AuthyVerificationCodeIsIncorrectException(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneVerificationNotFoundException : AuthyException
    {
        public AuthyPhoneVerificationNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyCouldNotGetPhoneInformationException : AuthyException
    {
        public AuthyCouldNotGetPhoneInformationException(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneInformationQueryServerErrorException : AuthyException
    {
        public AuthyPhoneInformationQueryServerErrorException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidUserException : AuthyException
    {
        public AuthyInvalidUserException(string message) : base(message)
        {
        }
    }

    public class AuthyUserCannotBeDeletedException : AuthyException
    {
        public AuthyUserCannotBeDeletedException(string message) : base(message)
        {
        }
    }

    public class AuthyActivityCouldNotBeCreatedException : AuthyException
    {
        public AuthyActivityCouldNotBeCreatedException(string message) : base(message)
        {
        }
    }

    public class AuthyIncorrectUserParamsException : AuthyException
    {
        public AuthyIncorrectUserParamsException(string message) : base(message)
        {
        }
    }

    public class AuthyActionNotAuthorizedException : AuthyException
    {
        public AuthyActionNotAuthorizedException(string message) : base(message)
        {
        }
    }

    public class AuthySmsNotFoundException : AuthyException
    {
        public AuthySmsNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidPhoneNumberException : AuthyException
    {
        public AuthyInvalidPhoneNumberException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidRegistrationRequestException : AuthyException
    {
        public AuthyInvalidRegistrationRequestException(string message) : base(message)
        {
        }
    }

    public class AuthyRegistrationRequestNotFoundException : AuthyException
    {
        public AuthyRegistrationRequestNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidRegistrationPinException : AuthyException
    {
        public AuthyInvalidRegistrationPinException(string message) : base(message)
        {
        }
    }

    public class AuthyRegistrationRequestExpiredException : AuthyException
    {
        public AuthyRegistrationRequestExpiredException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidEmailException : AuthyException
    {
        public AuthyInvalidEmailException(string message) : base(message)
        {
        }
    }

    public class AuthyUuidOrCountryCodeAndPhoneNumberRequiredException : AuthyException
    {
        public AuthyUuidOrCountryCodeAndPhoneNumberRequiredException(string message) : base(message)
        {
        }
    }

    public class AuthyMissingDashboardAccountIdsException : AuthyException
    {
        public AuthyMissingDashboardAccountIdsException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchApprovalRequestNotFoundException : AuthyException
    {
        public AuthyOneTouchApprovalRequestNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchUnregisteredUserException : AuthyException
    {
        public AuthyOneTouchUnregisteredUserException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchDeviceNotFoundException : AuthyException
    {
        public AuthyOneTouchDeviceNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyApprovalRequestFailedException : AuthyException
    {
        public AuthyApprovalRequestFailedException(string message) : base(message)
        {
        }
    }

    public class AuthyApprovalRequestNotPendingException : AuthyException
    {
        public AuthyApprovalRequestNotPendingException(string message) : base(message)
        {
        }
    }

    public class AuthyCustomerNotificationFailedException : AuthyException
    {
        public AuthyCustomerNotificationFailedException(string message) : base(message)
        {
        }
    }

    public class AuthyHttpsRequiredException : AuthyException
    {
        public AuthyHttpsRequiredException(string message) : base(message)
        {
        }
    }

    public class AuthyAccountTemporarilySuspendedException : AuthyException
    {
        public AuthyAccountTemporarilySuspendedException(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneNumberNotFoundException : AuthyException
    {
        public AuthyPhoneNumberNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyAccountSuspendedException : AuthyException
    {
        public AuthyAccountSuspendedException(string message) : base(message)
        {
        }
    }

    public class AuthyApplicationSuspendedException : AuthyException
    {
        public AuthyApplicationSuspendedException(string message) : base(message)
        {
        }
    }

    public class AuthyDisallowedIpAddressException : AuthyException
    {
        public AuthyDisallowedIpAddressException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchEnableFailedException : AuthyException
    {
        public AuthyOneTouchEnableFailedException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchMustBeEnabledException : AuthyException
    {
        public AuthyOneTouchMustBeEnabledException(string message) : base(message)
        {
        }
    }

    public class AuthyCallbackInformationSaveFailedException : AuthyException
    {
        public AuthyCallbackInformationSaveFailedException(string message) : base(message)
        {
        }
    }

    public class AuthyAccessBlockedForMultiDeviceUserException : AuthyException
    {
        public AuthyAccessBlockedForMultiDeviceUserException(string message) : base(message)
        {
        }
    }

    public class AuthyRegistrationDeviceUpdateFailedException : AuthyException
    {
        public AuthyRegistrationDeviceUpdateFailedException(string message) : base(message)
        {
        }
    }

    public class AuthyAccessKeyCanNotBeSavedException : AuthyException
    {
        public AuthyAccessKeyCanNotBeSavedException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidApplicationException : AuthyException
    {
        public AuthyInvalidApplicationException(string message) : base(message)
        {
        }
    }

    public class AuthyAccessKeyNotFoundException : AuthyException
    {
        public AuthyAccessKeyNotFoundException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidAccessKeyException : AuthyException
    {
        public AuthyInvalidAccessKeyException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidApplicationApiKeyException : AuthyException
    {
        public AuthyInvalidApplicationApiKeyException(string message) : base(message)
        {
        }
    }

    public class AuthyAccessKeyInsufficientPermissionsException : AuthyException
    {
        public AuthyAccessKeyInsufficientPermissionsException(string message) : base(message)
        {
        }
    }

    public class AuthyApplicationCouldNotBeDeletedException : AuthyException
    {
        public AuthyApplicationCouldNotBeDeletedException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidCountryCodeException : AuthyException
    {
        public AuthyInvalidCountryCodeException(string message) : base(message)
        {
        }
    }

    public class AuthyInvalidApprovalRequestException : AuthyException
    {
        public AuthyInvalidApprovalRequestException(string message) : base(message)
        {
        }
    }

    public class AuthyLandLineSmsNotAllowedException : AuthyException
    {
        public AuthyLandLineSmsNotAllowedException(string message) : base(message)
        {
        }
    }

    public class AuthyPhoneNumberNotProvisionedWithAnyCarrierException : AuthyException
    {
        public AuthyPhoneNumberNotProvisionedWithAnyCarrierException(string message) : base(message)
        {
        }
    }

    public class AuthyOneTouchNotEnabledException : AuthyException
    {
        public AuthyOneTouchNotEnabledException(string message) : base(message)
        {
        }
    }
}