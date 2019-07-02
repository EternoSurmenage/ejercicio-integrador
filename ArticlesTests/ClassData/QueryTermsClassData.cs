using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ArticlesAPI.Contracts;
using ArticlesAPI.Providers;
using ArticlesTests.MockProviders;

namespace ArticlesTests.ClassData
{
    class QueryTermsClassData : IEnumerable<object[]>
    {
        private readonly List<object[]> queryParameters= new List<object[]>
        {
          new object[] {null,null,null},
          new object[] {"TRUMP",new DateTime(2017,2,1),null },
          new object[] {"TRUMP", null,new DateTime(2017,2,1) },
        };


        public IEnumerator<object[]> GetEnumerator()
        { return queryParameters.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
