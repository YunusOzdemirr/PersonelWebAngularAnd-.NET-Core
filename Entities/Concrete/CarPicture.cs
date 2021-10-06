using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class CarPicture:EntityBase<int>,IEntity
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public byte[] File { get; set; }
    }
}

