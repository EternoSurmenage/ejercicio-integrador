using System.Threading.Tasks;
using ArticlesAPI.Contracts;
using ArticlesAPI.Models;
using ArticlesTests.MockRepositories;

namespace ArticlesTests.MockProviders
{
    class FakeTenArticlesProvider:IArticleProvider
    {
        public FakeTenArticlesProvider()
        {

        }
        public async Task<RootObject> GetArticles(string search, string startDate, string endDate)
        {
            RootObject rootObject = new ResponseWithTenArticles().rootObject;

            return rootObject;
        }
    }
}
