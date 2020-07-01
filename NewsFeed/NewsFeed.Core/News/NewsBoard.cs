using System;
using System.Collections.Generic;

namespace NewsFeed.Core
{
	public class NewsBoard
	{
		private List<Page> pages = new List<Page>();

		private string _name;

		private DateTime _date;

		private int _maxPages = 8;

		public int PageCount => pages.Count;

		public int MaxPages
		{
			get
			{
				return _maxPages;
			}
			set
			{
				_maxPages = value;
			}
		}

		public NewsBoard(string name, DateTime date)
		{
			_name = name;
			_date = date;
		}

		public Page CreatePage(int maxNewsPerPage, int maxAdvertisementPerPage, int pageNumber)
		{
			return new Page(maxNewsPerPage, maxAdvertisementPerPage, pageNumber);
		}

		public void AddPage(Page page)
		{
			if (pages.Count <= _maxPages)
			{
				pages.Add(page);
			}
			else
			{
				Console.WriteLine($"Can not add page to newspaper as max page count({_maxPages}) is reached.");
			}
		}

		public void RemovePage(Page page)
		{
			pages.Remove(page);
		}

		public void DisplayAllNews()
		{
			foreach (Page page in pages)
			{
				Console.WriteLine($"\n{_name} : {_date} : Displaying news from page {page.PageNumber}\n");
				foreach (News news in page.GetAllNews())
				{
					Console.WriteLine($"{news.SourceName}{news.PublishAt} : {news.Category}({news.Priority}) : {news.Content}");
				}
			}
		}
	}
}
