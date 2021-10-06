using System;
using Shared.Utilities.Results.Abstract;
using Shared.Entities.ComplexTypes;

namespace Shared.Utilities.Results.Concrete
{
    public class SuccessApiResult : ApiResult
    {
        public SuccessApiResult(IResult result, string href) : base(result.ResultStatus, result.Message, HttpStatusCode.OK,href)
        {
        }
    }
}

