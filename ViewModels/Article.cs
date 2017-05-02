using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.ViewModels
{
    public class Article
    {
        public string Title;
        public string Content;
        public DateTime CreatedDate;
        public DateTime ModifiedDate;
        public bool IsPublished;
        public List<String> Tags;
    }
}
