using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed.Core
{
	public class NewsReader
	{
		private List<INewsService> _newsServices = new List<INewsService>();

		public void RegisterNewsService(INewsService newsService)
		{
			_newsServices.Add(newsService);
		}

		public void UnRegisterNewsService(INewsService newsService)
		{
			_newsServices.Remove(newsService);
		}

		public IList<News> GetNews()
		{
			List<News> news = new List<News>();
			foreach (INewsService newsService in _newsServices)
			{
				news.AddRange(newsService.GetNews());
			}
			return news;
		}
	}
}
