using System;
namespace Shared.Entities.Abstract
{
    public abstract class EntityBase<T> where T:struct
    {
        public virtual T Id { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual Guid? CreatedByUserId { get; set; }
        public virtual Guid? ModifiedByUserId { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}

