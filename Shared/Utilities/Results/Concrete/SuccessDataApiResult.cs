using System;
using Shared.Utilities.Results.Abstract;
using Shared.Entities.ComplexTypes;

namespace Shared.Utilities.Results.Concrete
{
    public class SuccessDataApiResult:ApiResult
    {
        public SuccessDataApiResult(IDataResult dataResult, string href) : base(dataResult.ResultStatus, dataResult.Message, HttpStatusCode.OK,href)
        {
            Data = dataResult.Data;
        }
        public Object Data { get; set; }
    }
}

