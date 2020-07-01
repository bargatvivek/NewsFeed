using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed.Core
{
	public class News
	{
		private DateTime _publishAt;
		private Category _category;
		private Priority _priority;
		private string _content;
		private string _description;
		private string _title;
		private string _author;

		public DateTime PublishAt
		{
			get
			{
				return _publishAt;
			}
			set
			{
				_publishAt = value;
			}
		}

		public Category Category
		{
			get
			{
				return _category;
			}
			set
			{
				_category = value;
			}
		}

		public Priority Priority
		{
			get
			{
				return _priority;
			}
			set
			{
				_priority = value;
			}
		}

		public string Content
		{
			get
			{
				return _content;
			}
			set
			{
				_content = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		public string Author
		{
			get
			{
				return _author;
			}
			set
			{
				_author = value;
			}
		}

		public Source SourceName
		{
			get;
			set;
		}

		public News()
		{
			_publishAt = DateTime.Now;
		}

		public virtual string GetFormattedNews()
		{
			return _content ?? "";
		}
	}

	public enum Category
	{
		Political = 1,
		Sports,
		Travel,
		Advertisements
	}
	public enum Priority
	{
		Low = 1,
		High
	}
	public enum Source
	{
		Internal = 1,
		GoogleNews,
		PressTrustOfIndia
	}

}
