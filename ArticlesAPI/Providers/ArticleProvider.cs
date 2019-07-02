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

namespace ArticlesAPI.Providers
{
    public class ArticleProvider : IArticleProvider
    {
        private readonly IValidatorService _validatorService;
        private readonly HttpClient _httpClient;
        public ArticleProvider(IValidatorService validatorService)
        {
            _validatorService = validatorService;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.nytimes.com/svc/search/v2/articlesearch.json");
        }
        public async Task<RootObject> GetArticles(string search, string startDate, string endDate)
        {

            //string mockAPI = "http://demo5167316.mockable.io/";
            //string mockAPI = "http://www.mocky.io/v2/5d0d6fd43400004d00ca4a03";
            string APIKey = "i3gHCbiiqmc9OAQiKvpEY7AyjKaGi7hX";
            string filterFields = "web_url%2Csnippet%2Cheadline%2Cpub_date";
            string sortBy = "newest";

            HttpResponseMessage response = await _httpClient.GetAsync($"?api-key={APIKey}&q={search}&begin_date={startDate}&end_date={endDate}&sort={sortBy}&fl={filterFields}");
            //HttpResponseMessage response = await _httpClient.GetAsync(mockAPI);

            //If it doesn't pass this method, it returns a web exception 
            _validatorService.EnsureSuccessfulResponse(response);

            string responseBody = await response.Content.ReadAsStringAsync();
            // RootObject rootObject = response.Content;
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(responseBody);
            _validatorService.rootObjectIsNotNull(rootObject);

            return rootObject;
        }
    }
}