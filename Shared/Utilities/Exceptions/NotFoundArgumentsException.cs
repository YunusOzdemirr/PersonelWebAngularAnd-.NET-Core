using System;
using System.Collections.Generic;
using Shared.Entities.Concrete;

namespace Shared.Utilities.Exceptions
{
    public class NotFoundArgumentsException:Exception
    {
        public NotFoundArgumentsException(string message,IEnumerable<Error> validationErrors):base(message)
        {
            ValidationErros = validationErrors;
        }
        public IEnumerable<Error> ValidationErros{ get; set; }
    }
}

