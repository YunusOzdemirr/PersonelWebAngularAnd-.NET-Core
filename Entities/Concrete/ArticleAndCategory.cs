using System;
namespace Entities.Concrete
{
    public class ArticleAndCategory
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

