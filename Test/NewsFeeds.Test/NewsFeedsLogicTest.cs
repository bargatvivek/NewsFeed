using NUnit.Framework;
using Moq;
using NewsFeed.Core;

namespace NewsFeeds.Test
{
    public class NewsFeedsLogicTest
    {
        Mock<Page> mockPage;
        Mock<PageRules> mockPageRules;

        [SetUp]
        public void Setup()
        {
            mockPage = new Mock<Page>(MockBehavior.Strict, new object[] { 8, 2, 1 });

            var newsReader = new NewsReader();
            var allNews = newsReader.GetNews();

            foreach (News news in allNews)
            {
                mockPage.Object.AddNews(news);
            }

            mockPageRules = new Mock<PageRules>(MockBehavior.Strict, new object[] { mockPage.Object });
        }

        [Test]
        public void Max_8_News_On_A_Page_Returns_True()
        {
            Assert.AreEqual(true, mockPageRules.Object.IsPageFull());
        }

        [Test]
        public void Max_Advertisement_On_A_Page_Should_Be_2_Returns_True()
        {
            Assert.AreEqual(true, mockPageRules.Object.IsAdverstisementFull());
        }

        [Test]
        public void Advertisements_Can_Be_Dropped_If_High_Priority_News_Cannot_Accomodate_On_Page()
        {
            News news = new News();
            news.Content = "News from Google";
            news.Priority = Priority.High;
            news.SourceName = Source.GoogleNews;
            Assert.AreEqual(true, mockPageRules.Object.CanRemoveAdevertisement(news));
        }

    }
}
