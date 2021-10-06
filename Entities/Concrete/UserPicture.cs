using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class UserPicture:EntityBase<int>,IEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public byte[] File { get; set; }
    }
}

