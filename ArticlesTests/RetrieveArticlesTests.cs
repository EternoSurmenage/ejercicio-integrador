using System;
using Xunit;
using ArticlesAPI.Services;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ArticlesAPI.Models;
using ArticlesAPI.Contracts;
using System.Linq;
using ArticlesTests.MockRepositories;
using ArticlesTests.MockProviders;
using ArticlesTests.ClassData;
using ArticlesTests.Setters;

namespace ArticlesTests
{
    public class RetrieveArticlesTest
    {
        private Mock<IArticleProvider> mock;
        private ArticleService articleService;
        private readonly ValidatorService validatorService;

        private ContextSetter contextSetter;
        string search = "avengers";
        string start = "2010-06-01";
        string end = "2016-08-01";

        private readonly DateTime? startDate = DateTime.Now;
        private readonly DateTime? endDate = DateTime.Now;
        public RetrieveArticlesTest()
        {
            validatorService = new ValidatorService();
            articleService = new ArticleService(new FakeTenArticlesProvider(), validatorService);
            contextSetter = new ContextSetter();
        }

        [Fact]
        public void WhenCalledProperlyReturnsDocsList()
        {
            //Arrange
            contextSetter.SetContextProvider(new FakeTenArticlesProvider());
            //Action
            var result = articleService.RetrieveArticles(search, startDate, endDate);

            //Assert
            Assert.IsType<Task<IEnumerable<Doc>>>(result);
        }

        [Fact]
        public async Task WhenDocsResponseAreEmptyReturnsZeroDocsList()
        {
            //Arrange
            //Forma 1
            articleService = contextSetter.SetContextProvider(new FakeZeroArticlesProvider());

            //Action
            var result = await articleService.RetrieveArticles(search, startDate, endDate);

            //Assert
            Assert.True(result.Count() == 0);
        }

        [Theory, ClassData(typeof(ArticleProviderClassData))]
        public async Task WhenCalledProperlyReturnsAtMaxTenDocs(IArticleProvider articleProvider)
        {
            //Arrange
            articleService = contextSetter.SetContextProvider(articleProvider);
            //Action
            var result = await articleService.RetrieveArticles(search, startDate, endDate);

            //Assert
            Assert.True(result.Count() <= 10);
        }

        [Theory, ClassData(typeof(QueryTermsClassData))]
        public void WhenNotProperlyCalledReturnsException(string searchTerm, DateTime? start, DateTime? end)
        {
            //Arrange
            var result = articleService.RetrieveArticles(searchTerm, start, end);
            //Assert
            Assert.ThrowsAsync<Exception>(() => articleService.RetrieveArticles(searchTerm, start, end));

        }
    }
}
