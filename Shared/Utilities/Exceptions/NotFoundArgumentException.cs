﻿using System;
using Shared.Entities.Concrete;

namespace Shared.Utilities.Exceptions
{
    public class NotFoundArgumentException:Exception
    {
        public NotFoundArgumentException(string message,string errorMessage,string propertyName):base(message)
        {
        }
        public NotFoundArgumentException(string message,Error validationError):base(message)
        {
            ValidationError = validationError;
        }
        public Error ValidationError { get; set; }
    }
}

