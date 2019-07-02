using System.Threading.Tasks;
using ArticlesAPI.Models;
using System;
using System.Collections.Generic;

namespace ArticlesAPI.Contracts
{
    public interface IArticleService
    {
        IEnumerable<Doc> TakeDocs(RootObject rootObject);
        Task<IEnumerable<Doc>> RetrieveArticles(string search, DateTime? startDate, DateTime? endDate);

    }
}