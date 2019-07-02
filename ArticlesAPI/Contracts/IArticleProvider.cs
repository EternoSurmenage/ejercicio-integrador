using System.Threading.Tasks;
using ArticlesAPI.Models;
using System;
using System.Collections.Generic;

namespace ArticlesAPI.Contracts
{
    public interface IArticleProvider
    {
        Task<RootObject> GetArticles(string search, string startDate, string endDate);
    }
}