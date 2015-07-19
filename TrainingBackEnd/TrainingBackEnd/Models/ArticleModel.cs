using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class ArticleModel
    {
        public string Id;
        public string Heading;
    }

    public class ArticleFullModel : ArticleModel
    {
        public string Body;
    }
}