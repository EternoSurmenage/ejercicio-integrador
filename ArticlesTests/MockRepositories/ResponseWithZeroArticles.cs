using System;
using System.Collections.Generic;
using System.Text;
using ArticlesAPI.Models;

namespace ArticlesTests.MockRepositories
{
    class ResponseWithZeroArticles
    {
        public readonly RootObject rootObject;
        public ResponseWithZeroArticles()
        {
            rootObject = new RootObject()
            {
                Status = "OK",
                Copyright = "Copyright (c) 2019 The New York Times Company. All Rights Reserved.",
                Response = new Response()
                {
                    Meta = new Meta()
                    {
                        Hits = 320,
                        Offset = 30,
                        Time = 17
                    },
                    Docs = new List<Doc>(0) { }
                }
            };
        }
    }
}