using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArticlesTests.ClassData
{
    class InvalidDateRangeClassData:IEnumerable<object[]>
    {
        private readonly List<object[]> queryParameters = new List<object[]>
        {
          new object[] {null,new DateTime(2017,2,1)},
          new object[] {new DateTime(2017,2,1),null },
        };


        public IEnumerator<object[]> GetEnumerator()
        { return queryParameters.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
