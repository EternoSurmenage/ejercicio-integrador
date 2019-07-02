using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArticlesTests.ClassData
{
    class EmptyDateInputClassData:IEnumerable<object[]>
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
