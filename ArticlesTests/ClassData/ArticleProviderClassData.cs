using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ArticlesAPI.Contracts;
using ArticlesAPI.Providers;
using ArticlesTests.MockProviders;

namespace ArticlesTests.ClassData
{
    class ArticleProviderClassData: IEnumerable<object[]>
    {
        private readonly List<object[]> articleProviders = new List<object[]>
        {
          new object[] {new FakeTenArticlesProvider() },
          new object[] {new FakeZeroArticlesProvider() },
          new object[] {new FakeTwentyArticlesProvider()},
        };

        public IEnumerator<object[]> GetEnumerator()
        { return articleProviders.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
