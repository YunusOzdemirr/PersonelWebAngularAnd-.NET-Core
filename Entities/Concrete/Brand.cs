using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}

