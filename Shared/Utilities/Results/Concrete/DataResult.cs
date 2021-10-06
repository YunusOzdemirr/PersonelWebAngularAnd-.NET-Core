using System;
using Shared.Utilities.Results.Abstract;
using Shared.Utilities.Results.ComplexTypes;

namespace Shared.Utilities.Results.Concrete
{
    public class DataResult:IDataResult
    {
        public DataResult(ResultStatus resultStatus,Object data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus,string message, Object data)
        {
            ResultStatus = resultStatus;
            Data = data;
            Message = message;
        }

        public ResultStatus ResultStatus{ get; set; }
        public string Message { get; set; }
        public Object Data { get; set; }
    }
}

