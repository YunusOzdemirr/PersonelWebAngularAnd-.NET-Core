using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Color:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public ICollection<CarAndColor> CarAndColors { get; set; }
    }
}

