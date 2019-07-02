using System.Threading.Tasks;
using ArticlesAPI.Contracts;
using ArticlesAPI.Models;
using ArticlesTests.MockRepositories;
using ArticlesAPI.Exceptions;
using System;

namespace ArticlesTests.MockProviders
{
    class FakeNullArticleProvider:IArticleProvider
    {
        public async Task<RootObject> GetArticles(string search, string startDate, string endDate)
        {
            RootObject rootObject = null;
            throw new Exception();
            return rootObject;
        }
    }
}
