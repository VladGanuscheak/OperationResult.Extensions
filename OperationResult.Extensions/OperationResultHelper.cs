using System;
using Microsoft.AspNetCore.Http;

namespace OperationResult.Extensions
{
    public static class OperationResultHelper
    {
        #region OperationResult
        public static OperationResult BadRequest(params string[] messages)
            => FailureResult(StatusCodes.Status400BadRequest, messages);

        public static OperationResult Unauthorized(params string[] messages)
            => FailureResult(StatusCodes.Status401Unauthorized, messages);

        public static OperationResult PaymentRequired(params string[] messages)
            => FailureResult(StatusCodes.Status402PaymentRequired, messages);

        public static OperationResult Forbidden(params string[] messages)
            => FailureResult(StatusCodes.Status403Forbidden, messages);

        public static OperationResult NotFound(params string[] messages)
            => FailureResult(StatusCodes.Status404NotFound, messages);

        public static OperationResult MethodNotAllowed(params string[] messages)
            => FailureResult(StatusCodes.Status405MethodNotAllowed, messages);

        public static OperationResult NotAcceptable(params string[] messages)
            => FailureResult(StatusCodes.Status406NotAcceptable, messages);
        
        public static OperationResult ProxyAuthenticationRequired(params string[] messages)
            => FailureResult(StatusCodes.Status407ProxyAuthenticationRequired, messages);

        public static OperationResult RequestTimeout(params string[] messages)
            => FailureResult(StatusCodes.Status408RequestTimeout, messages);
        
        public static OperationResult Conflict(params string[] messages)
            => FailureResult(StatusCodes.Status409Conflict, messages);
        
        public static OperationResult Gone(params string[] messages)
            => FailureResult(StatusCodes.Status410Gone, messages);
        
        public static OperationResult LengthRequired(params string[] messages)
            => FailureResult(StatusCodes.Status411LengthRequired, messages);

        public static OperationResult PreconditionFailed(params string[] messages)
            => FailureResult(StatusCodes.Status412PreconditionFailed, messages);
        
        public static OperationResult RequestEntityTooLarge(params string[] messages)
            => FailureResult(StatusCodes.Status413RequestEntityTooLarge, messages);

        public static OperationResult PayloadTooLarge(params string[] messages)
            => FailureResult(StatusCodes.Status413PayloadTooLarge, messages);

        public static OperationResult RequestUriTooLong(params string[] messages)
            => FailureResult(StatusCodes.Status414RequestUriTooLong, messages);
        
        public static OperationResult UriTooLong(params string[] messages)
            => FailureResult(StatusCodes.Status414UriTooLong, messages);

        public static OperationResult UnsupportedMediaType(params string[] messages)
            => FailureResult(StatusCodes.Status415UnsupportedMediaType, messages);

        public static OperationResult RequestedRangeNotSatisfiable(params string[] messages)
            => FailureResult(StatusCodes.Status416RequestedRangeNotSatisfiable, messages);

        public static OperationResult RangeNotSatisfiable(params string[] messages)
            => FailureResult(StatusCodes.Status416RangeNotSatisfiable, messages);

        public static OperationResult ExpectationFailed(params string[] messages)
            => FailureResult(StatusCodes.Status417ExpectationFailed, messages);
    
        public static OperationResult ImATeapot(params string[] messages)
            => FailureResult(StatusCodes.Status418ImATeapot, messages);
    
        public static OperationResult AuthenticationTimeout(params string[] messages)
            => FailureResult(StatusCodes.Status419AuthenticationTimeout, messages);
    
        public static OperationResult MisdirectedRequest(params string[] messages)
            => FailureResult(StatusCodes.Status421MisdirectedRequest, messages);

        public static OperationResult UnprocessableEntity(params string[] messages)
            => FailureResult(StatusCodes.Status422UnprocessableEntity, messages);
    
        public static OperationResult Locked(params string[] messages)
            => FailureResult(StatusCodes.Status423Locked, messages);
        
        public static OperationResult FailedDependency(params string[] messages)
            => FailureResult(StatusCodes.Status424FailedDependency, messages);
        
        public static OperationResult UpgradeRequired(params string[] messages)
            => FailureResult(StatusCodes.Status426UpgradeRequired, messages);

        public static OperationResult PreconditionRequired(params string[] messages)
            => FailureResult(StatusCodes.Status428PreconditionRequired, messages);

        public static OperationResult TooManyRequests(params string[] messages)
            => FailureResult(StatusCodes.Status429TooManyRequests, messages);

        public static OperationResult RequestHeaderFieldsTooLarge(params string[] messages)
            => FailureResult(StatusCodes.Status431RequestHeaderFieldsTooLarge, messages);

        public static OperationResult UnavailableForLegalReasons(params string[] messages)
            => FailureResult(StatusCodes.Status451UnavailableForLegalReasons, messages);
        #endregion

        #region OperationResult<TData>
        public static OperationResult<TData> BadRequest<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status400BadRequest, messages);

        public static OperationResult<TData> Unauthorized<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status401Unauthorized, messages);

        public static OperationResult<TData> PaymentRequired<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status402PaymentRequired, messages);

        public static OperationResult<TData> Forbidden<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status403Forbidden, messages);

        public static OperationResult<TData> NotFound<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status404NotFound, messages);

        public static OperationResult<TData> MethodNotAllowed<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status405MethodNotAllowed, messages);

        public static OperationResult<TData> NotAcceptable<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status406NotAcceptable, messages);

        public static OperationResult<TData> ProxyAuthenticationRequired<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status407ProxyAuthenticationRequired, messages);

        public static OperationResult<TData> RequestTimeout<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status408RequestTimeout, messages);

        public static OperationResult<TData> Conflict<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status409Conflict, messages);

        public static OperationResult<TData> Gone<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status410Gone, messages);

        public static OperationResult<TData> LengthRequired<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status411LengthRequired, messages);

        public static OperationResult<TData> PreconditionFailed<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status412PreconditionFailed, messages);

        public static OperationResult<TData> RequestEntityTooLarge<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status413RequestEntityTooLarge, messages);

        public static OperationResult<TData> PayloadTooLarge<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status413PayloadTooLarge, messages);

        public static OperationResult<TData> RequestUriTooLong<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status414RequestUriTooLong, messages);

        public static OperationResult<TData> UriTooLong<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status414UriTooLong, messages);

        public static OperationResult<TData> UnsupportedMediaType<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status415UnsupportedMediaType, messages);

        public static OperationResult<TData> RequestedRangeNotSatisfiable<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status416RequestedRangeNotSatisfiable, messages);

        public static OperationResult<TData> RangeNotSatisfiable<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status416RangeNotSatisfiable, messages);

        public static OperationResult<TData> ExpectationFailed<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status417ExpectationFailed, messages);

        public static OperationResult<TData> ImATeapot<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status418ImATeapot, messages);

        public static OperationResult<TData> AuthenticationTimeout<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status419AuthenticationTimeout, messages);

        public static OperationResult<TData> MisdirectedRequest<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status421MisdirectedRequest, messages);

        public static OperationResult<TData> UnprocessableEntity<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status422UnprocessableEntity, messages);

        public static OperationResult<TData> Locked<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status423Locked, messages);

        public static OperationResult<TData> FailedDependency<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status424FailedDependency, messages);

        public static OperationResult<TData> UpgradeRequired<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status426UpgradeRequired, messages);

        public static OperationResult<TData> PreconditionRequired<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status428PreconditionRequired, messages);

        public static OperationResult<TData> TooManyRequests<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status429TooManyRequests, messages);

        public static OperationResult<TData> RequestHeaderFieldsTooLarge<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status431RequestHeaderFieldsTooLarge, messages);

        public static OperationResult<TData> UnavailableForLegalReasons<TData>(params string[] messages)
            => FailureResult<TData>(StatusCodes.Status451UnavailableForLegalReasons, messages);
        #endregion

        private static void EnsureFailureStatusCode(int code)
        {
            if (code < 400 || code >= 500)
            {
                throw new ArgumentException("The result failure code does not enter in the [400-499] http status code range!");
            }
        }

        private static OperationResult FailureResult(int code, params string[] messages)
        {
            EnsureFailureStatusCode(code);

            OperationResult result = OperationResult.Failed()
                .WithCode(code.ToString());

            if (messages.Length > 0)
            {
                foreach(var message in messages)
                {
                    result.WithMessage(message);
                }
            }

            return result;
        }

        private static OperationResult<TData> FailureResult<TData>(int code, params string[] messages)
        {
            EnsureFailureStatusCode(code);

            var result = OperationResult<TData>.Failed()
                .WithCode(code.ToString());

            if (messages.Length > 0)
            {
                foreach (var message in messages)
                {
                    result.WithMessage(message);
                }
            }

            return result;
        }
    }
}
