using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class ArticlePicture:EntityBase<int>,IEntity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public byte[] File{ get; set; }
    }
}

