using System;
using System.Collections.Generic;
using System.Text;
using ArticlesAPI.Models;

namespace ArticlesTests.MockRepositories
{
    class ResponseWithTwentyArticles
    {
        public readonly RootObject rootObject;
        public ResponseWithTwentyArticles()
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
                    Docs = new List<Doc>()
                    {
                        new Doc()
                        {
                            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet ="The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main= "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker=null,
                                ContentKicker=null,
                                PrintHeadline=null,
                                Name=null,
                                Seo=null,
                                Sub=null
                            },
                            Pub_Date=new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                           new Doc()
                        {
                            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet ="The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main= "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker=null,
                                ContentKicker=null,
                                PrintHeadline=null,
                                Name=null,
                                Seo=null,
                                Sub=null
                            },
                            Pub_Date=new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                        new Doc()
        {
            Web_URL = "https://www.notexists.com/2016/03/24/world/americas/obama-visit-affirms-argentinas-shift-toward-center.html",
                            Snippet = "The president is also said to be seeking to firm up the United States’ position in the region, where China has been establishing a foothold.",
                            Headline = new Headline()
                            {
                                Main = "Obama Visit Affirms Argentina’s Shift Toward Center",
                                Kicker = null,
                                ContentKicker = null,
                                PrintHeadline = null,
                                Name = null,
                                Seo = null,
                                Sub = null
                            },
                            Pub_Date = new DateTime(2010,1,28)
        },
                    }
                }
            };
        }
    }
}