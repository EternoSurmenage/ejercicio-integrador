using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Security.Authentication;
using ArticlesAPI.Models;
using ArticlesAPI.Services;
using ArticlesAPI.Exceptions;
using ArticlesAPI.Contracts;
using ArticlesAPI.Providers;

namespace ArticlesAPI.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleProvider _articleProvider;
        private readonly IValidatorService _validatorService;
        //private readonly HttpClient _httpClient;

      //  public IArticleProvider ArticleProvider {get;set;}
        public ArticleService(IArticleProvider articleProvider, IValidatorService validatorService)
        {
            _articleProvider = articleProvider;
           // _httpClient = new HttpClient();
            _validatorService = validatorService;
        }

        // Set articles status based on if their urls are available or not.
        public async Task<IEnumerable<Doc>> SetArticlesStatus(IEnumerable<Doc> docs)
        {
            return await this._validatorService.SetArticlesStatus(docs);
        }

        // Takes 10 articles from response and return them as a list of docs
        public IEnumerable<Doc> TakeDocs(RootObject rootObject)
        {
            return rootObject.Response.Docs.Take(10).ToList();
        }

        public async Task<IEnumerable<Doc>> RetrieveArticles(string search, DateTime? startDate, DateTime? endDate)
        {
            string start = startDate.Value.ToString("yyyyMMdd");
            string end = endDate.Value.ToString("yyyyMMdd");

            // string start = DateTime.MaxValue.ToString("yyyyMMdd");
            // string end = DateTime.MinValue.ToString("yyyyMMdd");

            RootObject rootObject = await _articleProvider.GetArticles(search, start, end);
            var docs = this.TakeDocs(rootObject);
            //return await this.SetArticlesStatus(docs);
            return docs;
        }


    }
}
