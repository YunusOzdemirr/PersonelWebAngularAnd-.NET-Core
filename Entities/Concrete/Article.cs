using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Article:EntityBase<int>,IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public sbyte  StarAverage { get; set; }
        public int TotalStarCount { get; set; }
        public ICollection<ArticlePicture> ArticlePictures { get; set; }
        public ICollection<Comment> Comments{ get; set; }
        public ICollection<ArticleAndCategory> ArticleAndCategories { get; set; }
    }
}

