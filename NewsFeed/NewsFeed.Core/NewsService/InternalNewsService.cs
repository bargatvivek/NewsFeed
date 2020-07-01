using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed.Core
{
	public class InternalNewsService : INewsService
	{
		public IEnumerable<News> GetNews()
		{
			return MockNewsData.GetStaticNews(Source.Internal);
		}
	}
}
