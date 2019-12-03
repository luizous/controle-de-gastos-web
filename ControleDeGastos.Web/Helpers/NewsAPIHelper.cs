using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Web.Helpers
{
    public static class NewsAPIHelper
    {
        public static List<Article> GetNews()
        {
            var newsApiClient = new NewsApiClient("ac2fa28697404e22b0c3be0ab52a35f2");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = Languages.BR,
                Category = Categories.Business,
                Country = Countries.BR,
                PageSize = 5
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                return articlesResponse.Articles;
            }
            return null;
        }
    }
}
