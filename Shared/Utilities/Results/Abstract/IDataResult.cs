using System;
namespace Shared.Utilities.Results.Abstract
{
    public interface IDataResult:IResult
    {
        public object Data { get; }
    }
}

