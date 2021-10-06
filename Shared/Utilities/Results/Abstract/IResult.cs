using System;
using Shared.Utilities.Results.ComplexTypes;

namespace Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
    }
}

