using System;
using System.Linq;

namespace NewsFeed.Core
{
	public class PageRules
	{
		private Page _page;

		public Page Page
		{
			get
			{
				return _page;
			}
			set
			{
				_page = value;
			}
		}

		public PageRules(Page page)
		{
			_page = page;
		}

		public bool IsPageFull()
		{
			return _page.MaxNewsPerPage == _page.GetAllNews().ToList().Count;
		}

		public bool IsAdverstisementFull()
		{
			return _page.MaxAdvertisementPerPage == _page.GetAllNews().Count((News c) => c.Category == Category.Advertisements);
		}

		public bool CanRemoveAdevertisement(News news)
		{
			return _page.GetAllNews().ToList().Count == _page.MaxNewsPerPage && news.Priority == Priority.High && _page.GetAllNews().Count((News c) => c.Category == Category.Advertisements) > 0;
		}

		public bool ValidatePage(News news)
		{
			if (news.Category == Category.Advertisements && IsAdverstisementFull())
			{
				Console.WriteLine($"Can not add adverstisement as maximum adv count({_page.MaxAdvertisementPerPage}) is reached");
				return false;
			}
			if (IsPageFull() && !CanRemoveAdevertisement(news))
			{
				Console.WriteLine("Can not add news/adverstisement as page is full");
				return false;
			}
			return true;
		}
	}

}
