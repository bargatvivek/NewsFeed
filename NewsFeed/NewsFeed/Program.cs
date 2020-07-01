using NewsFeed.Core;
using System;
using System.Threading;

namespace NewsFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsReader newsReader = new NewsReader();
            newsReader.RegisterNewsService(new GoogleNewsService());
            newsReader.RegisterNewsService(new PressTrustOfIndiaNewsService());
            newsReader.RegisterNewsService(new InternalNewsService());

            NewsBoard newsPaper = new NewsBoard("NEWS CHANNEL", DateTime.Now);
            newsPaper.MaxPages = 2;
            int maxNewsPerPage = 8; 
            int maxAdvertisementPerPage = 2; 
            int pageNumber = 1;

            Page page = newsPaper.CreatePage(maxNewsPerPage, maxAdvertisementPerPage, pageNumber);
            newsPaper.AddPage(page);

            while (true)
            {
                // Get all news from different registered services
                var allNews = newsReader.GetNews();
                foreach (News news in allNews)
                {
                    if (page.IsPageFull())
                    {
                        page = newsPaper.CreatePage(maxNewsPerPage, maxAdvertisementPerPage, (newsPaper.PageCount + 1));
                        newsPaper.AddPage(page);
                    }
                    page.AddNews(news);
                }

                newsPaper.DisplayAllNews();
                Thread.Sleep(3000);
            }
        }
    }
}
