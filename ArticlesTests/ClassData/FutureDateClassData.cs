using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArticlesTests.ClassData
{
    class FutureDateClassData : IEnumerable<object[]>
    {
        private readonly List<object[]> queryParameters = new List<object[]>
        {
          new object[] {new DateTime(2016,2,1),new DateTime(2022,2,1)},
          new object[] {new DateTime(2022,2,1),new DateTime(2020,2,1) },
           new object[] {new DateTime(2020,2,1),new DateTime(2010,2,1) },
        };

        public IEnumerator<object[]> GetEnumerator()
        { return queryParameters.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
