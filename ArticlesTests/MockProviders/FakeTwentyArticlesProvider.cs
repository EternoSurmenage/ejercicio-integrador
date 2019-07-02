using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ArticlesAPI.Contracts;
using ArticlesAPI.Models;
using ArticlesTests.MockRepositories;

namespace ArticlesTests.MockProviders
{
    class FakeTwentyArticlesProvider : IArticleProvider
    {
        public FakeTwentyArticlesProvider()
        {

        }
        public async Task<RootObject> GetArticles(string search, string startDate, string endDate)
        {
            RootObject rootObject = new ResponseWithTwentyArticles().rootObject;

            return rootObject;
        }
    }
}