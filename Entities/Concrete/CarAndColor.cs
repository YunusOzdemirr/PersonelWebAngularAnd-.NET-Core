using System;
namespace Entities.Concrete
{
    public class CarAndColor
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}

