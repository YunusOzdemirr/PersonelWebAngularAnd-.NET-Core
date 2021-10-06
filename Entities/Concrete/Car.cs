using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Car:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int BrandId { get; set; }
        public Brand Brand{ get; set; }
        public ICollection<CarAndColor> CarAndColors{ get; set; }
    }
}

