using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed.Core
{
	public class Page
	{
		private int _maxNewsPerPage = 0;

		private int _pageNumber;

		private int _maxAdvertisementPerPage = 0;

		private List<News> newsList = new List<News>();

		private PageRules pageRules;

		public int MaxNewsPerPage
		{
			get
			{
				return _maxNewsPerPage;
			}
			set
			{
				_maxNewsPerPage = value;
			}
		}

		public int MaxAdvertisementPerPage
		{
			get
			{
				return _maxAdvertisementPerPage;
			}
			set
			{
				_maxAdvertisementPerPage = value;
			}
		}

		public int PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set
			{
				_pageNumber = value;
			}
		}

		public Page(int maxNewsPerPage, int maxAdvertisementPerPage, int pageNumber)
		{
			_maxNewsPerPage = maxNewsPerPage;
			_maxAdvertisementPerPage = maxAdvertisementPerPage;
			_pageNumber = pageNumber;
			pageRules = new PageRules(this);
		}

		public void AddNews(News news)
		{
			if (pageRules.ValidatePage(news))
			{
				if (pageRules.CanRemoveAdevertisement(news))
				{
					News newsToRemove = (from c in newsList
										 where c.Category == Category.Advertisements
										 orderby c.PublishAt
										 select c).First();
					newsList.Remove(newsToRemove);
					Console.WriteLine($"maxcount({MaxNewsPerPage}) is reached and high priority {news.GetType().Name} news received from {news.SourceName}");
					newsList.Add(news);
				}
				else
				{
					newsList.Add(news);
				}
			}
		}

		public void RemoveNews(News news)
		{
			newsList.Remove(news);
		}

		public bool IsPageFull()
		{
			return MaxNewsPerPage == newsList.Count;
		}

		public IEnumerable<News> GetAllNews()
		{
			return newsList;
		}
	}
}
