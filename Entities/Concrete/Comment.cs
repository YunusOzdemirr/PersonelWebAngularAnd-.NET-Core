using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment:EntityBase<int>,IEntity
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public sbyte Star { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}

