using System;
using Shared.Utilities.Results.Abstract;
using Shared.Utilities.Results.ComplexTypes;

namespace Shared.Utilities.Results.Concrete
{
    public class Result:IResult
    {
        public Result(ResultStatus resultStatus,string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(string message)
        {
            Message = message;
        }
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
    }
}

