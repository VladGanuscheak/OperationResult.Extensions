using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OperationResult.Results;
using System;

namespace OperationResult.Extensions
{
    public static class OperationResultExtensions
    {
        public static ActionResult AsOkOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status200OK);
        }

        public static ActionResult AsAcceptedOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status202Accepted);
        }

        public static ActionResult AsNonAuthoritativeOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status203NonAuthoritative);
        }

        public static ActionResult AsNoContentOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status204NoContent);
        }

        public static ActionResult AsResetContentOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status205ResetContent);
        }

        public static ActionResult AsPartialContentOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status206PartialContent);
        }

        public static ActionResult AsMultiStatusOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status207MultiStatus);
        }

        public static ActionResult AsAlreadyReportedOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status208AlreadyReported);
        }

        public static ActionResult AsIMUsedOrFailure(this OperationResult result)
        {
            return result.AsActionResult(StatusCodes.Status226IMUsed);
        }

        public static ActionResult AsOkOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status200OK);
        }

        public static ActionResult AsCreatedOrFailure<TData>(this OperationResult<TData> result, string url)
        {
            return result.AsCreatedResult(url);
        }

        public static ActionResult AsCreatedOrFailure<TData>(this OperationResult<TData> result, Uri uri)
        {
            return result.AsCreatedResult(uri);
        }

        public static ActionResult AsAcceptedOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status202Accepted);
        }

        public static ActionResult AsNonAuthoritativeOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status203NonAuthoritative);
        }

        public static ActionResult AsNoContentOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status204NoContent);
        }

        public static ActionResult AsResetContentOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status205ResetContent);
        }

        public static ActionResult AsPartialContentOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status206PartialContent);
        }

        public static ActionResult AsMultiStatusOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status207MultiStatus);
        }

        public static ActionResult AsAlreadyReportedOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status208AlreadyReported);
        }

        public static ActionResult AsIMUsedOrFailure<TData>(this OperationResult<TData> result)
        {
            return result.AsActionResult(StatusCodes.Status226IMUsed);
        }

        private static void CheckIfStatusisSuccessfull(int successResultCode)
        {
            if (100 > successResultCode || successResultCode >= 400)
            {
                throw new ArgumentException("The successful status code result must be in the http codes range of [100, 400).");
            }
        }

        private static void CheckIfIsValidErrorCode(int httpCode)
        {
            if (httpCode < 400 || httpCode >= 500)
            {
                throw new ArgumentException("The http code isn't in the [400, 500)");
            }
        }

        private static ActionResult AsActionResult(this OperationResult result, int successResultCode)
        {
            CheckIfStatusisSuccessfull(successResultCode);
            if (result.HasSucceeded)
            {
                return new StatusCodeResult(successResultCode);
            }

            Tuple<BadRequestObjectResult, int> badRequest = result.GetBadRequest();
            if (badRequest.Item1 != null)
            {
                return badRequest.Item1;
            }

            CheckIfIsValidErrorCode(badRequest.Item2);
            ObjectResult objectResult = new ObjectResult(result.Messages);
            objectResult.StatusCode = badRequest.Item2;
            return objectResult;
        }

        private static ObjectResult AsSuccessObjectResult<TData>(this OperationResult<TData> result, int successResultCode)
        {
            if (successResultCode == 204)
            {
                ObjectResult objectResult = new ObjectResult(null);
                objectResult.StatusCode = successResultCode;
                return objectResult;
            }

            ObjectResult objectResult2 = new ObjectResult(((SuccessOperationResult<TData>)result).Data);
            objectResult2.StatusCode = successResultCode;
            return objectResult2;
        }

        private static Tuple<BadRequestObjectResult, int> GetBadRequest(this OperationResult result)
        {
            int result2;
            bool flag = int.TryParse(result.Code, out result2);
            if (string.IsNullOrEmpty(result.Code) || string.IsNullOrWhiteSpace(result.Code))
            {
                return new Tuple<BadRequestObjectResult, int>(new BadRequestObjectResult(result.Messages), 400);
            }

            if (!flag)
            {
                throw new ArgumentException("The http code of the error/failure result wasn't specified as a numeric number!");
            }

            return new Tuple<BadRequestObjectResult, int>(null, result2);
        }

        private static ActionResult AsActionResult<TData>(this OperationResult<TData> result, int successResultCode)
        {
            CheckIfStatusisSuccessfull(successResultCode);
            if (result.HasSucceeded)
            {
                return result.AsSuccessObjectResult(successResultCode);
            }

            Tuple<BadRequestObjectResult, int> badRequest = result.GetBadRequest();
            if (badRequest.Item1 != null)
            {
                return badRequest.Item1;
            }

            CheckIfIsValidErrorCode(badRequest.Item2);
            ObjectResult objectResult = new ObjectResult(result.Messages);
            objectResult.StatusCode = badRequest.Item2;
            return objectResult;
        }

        private static ActionResult AsCreatedResult<TData>(this OperationResult<TData> result, string url)
        {
            int successResultCode = 201;
            CheckIfStatusisSuccessfull(successResultCode);
            if (result.HasSucceeded)
            {
                return new CreatedResult(url, ((SuccessOperationResult<TData>)result).Data);
            }

            Tuple<BadRequestObjectResult, int> badRequest = result.GetBadRequest();
            if (badRequest.Item1 != null)
            {
                return badRequest.Item1;
            }

            CheckIfIsValidErrorCode(badRequest.Item2);
            ObjectResult objectResult = new ObjectResult(result.Messages);
            objectResult.StatusCode = badRequest.Item2;
            return objectResult;
        }

        private static ActionResult AsCreatedResult<TData>(this OperationResult<TData> result, Uri uri)
        {
            int successResultCode = 201;
            CheckIfStatusisSuccessfull(successResultCode);
            if (result.HasSucceeded)
            {
                return new CreatedResult(uri, ((SuccessOperationResult<TData>)result).Data);
            }

            Tuple<BadRequestObjectResult, int> badRequest = result.GetBadRequest();
            if (badRequest.Item1 != null)
            {
                return badRequest.Item1;
            }

            CheckIfIsValidErrorCode(badRequest.Item2);
            ObjectResult objectResult = new ObjectResult(result.Messages);
            objectResult.StatusCode = badRequest.Item2;
            return objectResult;
        }
    }
}
