using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public ICollection<ArticleAndCategory> ArticleAndCategories{ get; set; }
    }
}

