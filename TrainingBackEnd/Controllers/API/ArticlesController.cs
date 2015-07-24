using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Training.Code;
using Training.Models;
using Umbraco.Web.WebApi;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Net;

namespace Training.Controllers
{
    public class ArticlesController : BaseController
    {

        // Gets all trains and returns json serialized from List<TrainBaseModel>
        public HttpResponseMessage GetAll()
        {
            List<ArticleModel> model = new List<ArticleModel>();
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            IEnumerable<IPublishedContent> articles = root.Descendants("Article");
            if (articles.Any())
            {
                foreach (IPublishedContent article in articles)
                {
                    model.Add(new ArticleModel()
                    {
                        Id = article.Id.ToString(),
                        Heading = article.GetString("heading"),
                        Alias = article.GetString("alias")
                    });
                }
            }
            return Json(model);
        }

        public HttpResponseMessage GetById(string id)
        {
            try
            {
                IPublishedContent page = Umbraco.TypedContent(id);
                if (page.DocumentTypeAlias == "Article")
                {
                    ArticleFullModel article = new ArticleFullModel
                    {
                        Id = page.Id.ToString(),
                        Heading = page.GetString("heading"),
                        Body = page.GetString("body").ChangeUrlsToAbsolute()
                    };
                    return Json(article);
                }
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }


    }
}