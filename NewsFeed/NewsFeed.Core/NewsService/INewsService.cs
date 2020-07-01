using System.Collections.Generic;

namespace NewsFeed.Core
{
    public interface INewsService
    {
        IEnumerable<News> GetNews();
    }
}
