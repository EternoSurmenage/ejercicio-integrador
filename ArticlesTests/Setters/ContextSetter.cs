using System;
using System.Collections.Generic;
using System.Text;
using ArticlesAPI.Contracts;
using ArticlesAPI.Services;

namespace ArticlesTests.Setters
{
    class ContextSetter
    {
        private readonly ValidatorService validatorService;
        private ArticleService articleService;

        public ContextSetter()
        {
            // this.articleService = articleService;
            validatorService = new ValidatorService();
        }
        //Forma 1
        public ArticleService SetContextProvider(IArticleProvider provider)
        {
            this.articleService = new ArticleService(provider, validatorService);
            return articleService;
        }
        //Forma 2
        public void SetContextProvider(IArticleService articleService, IArticleProvider provider)
        {
            articleService = new ArticleService(provider, validatorService);
        }
    }
}
