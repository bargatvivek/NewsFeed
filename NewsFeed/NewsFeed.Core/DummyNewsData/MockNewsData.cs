using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Reflection;
using System.Security.Permissions;
using System;

namespace NewsFeed.Core
{
	public static class MockNewsData
	{
		public static List<News> GetStaticNews(Source source)
		{
			var news = new List<News>()
			{
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "Pierluigi Paganini",
					Title = "Personal data of thousands of users from the UK, Australia, South Africa, the US, Singapore exposed in bitcoin scam",
					Description = "Group-IB discovered thousands of personal records of users from multiple countries exposed in a targeted multi-stage bitcoin scam. Group-IB, a global threat hunting and intelligence company headquartered in Singapore, has discovered thousands of personal reco…",
					PublishAt = DateTime.Now,
					Content = "Group-IB, a global threat hunting and intelligence company headquartered in Singapore, has discovered thousands of personal records of users from the UK, Australia, South Africa, the US, Singapore, S… [+6190 chars]",
					Category = Category.Political,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.PressTrustOfIndia,
					Author = "Zack Voell",
					Title = "Coin Metrics Offers More Rigorous Measure of Crypto Market Supply",
					Description = "Coin Metrics offers a standardized way of measuring the size and depth of digital asset markets with free float supply methodology.",
					PublishAt = DateTime.Now,
					Content = "Cryptocurrency investors have long sought a standardized way of measuring the size and depth of digital asset markets. A new data product from Coin Metrics seeks a way to approximate it. The crypto… [+2638 chars]",
					Category = Category.Sports,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "pavroo",
					Title = "SparkyLinux: Sparky news 2020/06",
					Description = "The 6th monthly report of 2020 of the Sparky project: Linux kernel updated up to version 5.7.6 & 5.8-rc3 added to repos: Popcorn-Time, eDEX-UI, Visual Studio Code, VSCodium, Bitcoin-Qt, Litecoin-Qt Sparky 2020.06 of the rolling line released a point r…",
					PublishAt = DateTime.Now,
					Content = "The 6th monthly report of 2020 of the Sparky project: Linux kernel updated up to version 5.7.6 &amp; 5.8-rc3added to repos: Popcorn-Time, eDEX-UI, Visual Studio Code, VSCodium, Bitcoin-Qt, Litecoin… [+105 chars]",
					Category = Category.Travel,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "",
					Title = "Advertisement 1",
					Description = "Advertisement 1",
					PublishAt = DateTime.Now,
					Content = "Advertisement 1",
					Category = Category.Advertisements,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "Niloofer Shaikh",
					Title = "On the hour",
					Description = "S&P -0.06%.10-yr flat.Euro -0.41% vs. dollar.Crude -1.66% to $39.04.Gold -0.23% to $1,777.10.Bitcoin +0.68% to $9,159.",
					PublishAt = DateTime.Now,
					Content = "S&amp;P -0.06%.10-yr flat.Euro -0.41% vs. dollar.Crude -1.66% to $39.04.Gold -0.23% to $1,777.10.Bitcoin +0.68% to $9,159.",
					Category = Category.Political,
					Priority = Priority.Low,
				},
				new News()
				{
					SourceName = Source.Internal,
					Author = "Mike Rivero",
					Title = "This Russia-Afghanistan Story Is Western Propaganda At Its Most Vile",
					Description = "All western mass media outlets are now shrieking about the story The New York Times first reported, citing zero evidence and naming zero sources, claiming intelligence says Russia paid out bounties to Taliban-linked fighters in Afghanistan for attacking the o…",
					PublishAt = DateTime.Now,
					Content = "All western mass media outlets are now shrieking about the story The New York Timesfirst reported, citing zero evidence and naming zero sources, claiming intelligence says Russia paid out bounties to… [+9180 chars]",
					Category = Category.Sports,
					Priority = Priority.Low,
				},
				new News()
				{
					SourceName = Source.Internal,
					Author = "Huw Jones",
					Title = "More Britons take a bet on bitcoin - Reuters",
					Description = "The number of people in Britain buying cryptoassets like bitcoin and ether has more than doubled over the past year, but many are still unaware they have no protection against mis-selling, the Financial Conduct Authority said on Tuesday.",
					PublishAt = DateTime.Now,
					Content = "LONDON (Reuters) - The number of people in Britain buying cryptoassets like bitcoin BTC=BTSP and ether has more than doubled over the past year, but many are still unaware they have no protection aga… [+1682 chars]",
					Category = Category.Travel,
					Priority = Priority.Low,
				},
				new News()
				{
					SourceName = Source.Internal,
					Author = "",
					Title = "Advertisement 2",
					Description = "Advertisement 2",
					PublishAt = DateTime.Now,
					Content = "Advertisement 2",
					Category = Category.Advertisements,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "",
					Title = "",
					Description = "",
					PublishAt = DateTime.Now,
					Content = "",
					Category = Category.Political,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.GoogleNews,
					Author = "Bradley Keoun",
					Title = "First Mover: Bitwise Calls $50K Bitcoin Price When Market Calm Finally Breaks",
					Description = "In the calm before the storm, Bitwise suggests Bitcoin could be looking at territory well north of the previous $20,000 all-time high.",
					PublishAt = DateTime.Now,
					Content = "Bitcoin has traded in an ever-tightening range for two months, and digital-market analysts say a new wave of coronavirus cases and emergency measures could provoke the largest cryptocurrency by marke… [+5735 chars]",
					Category = Category.Travel,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.PressTrustOfIndia,
					Author = "Ben Jessel, Contributor, Ben Jessel, Contributorhttps://www.forbes.com/sites/benjessel/",
					Title = "Crypto In Crisis? Lewis Cohen And Greg Strong Share Their Views On Recent Lawsuits",
					Description = "Crypto appears to be under attach with a spate of regulatory and civil proceedings. Could this spell the end for crypto as we know it ? Experts Lewis Cohen and Greg Strong from blockchain and technology law firm, Dlx law gives us the rundown on the actions and…",
					PublishAt = DateTime.Now,
					Content = "DLx LawDLx LawThe tide has turned in the crypto industry. The stories in the press concerning announcements of new protocols have increasingly been replaced with announcements around enforcement … [+12998 chars]",
					Category = Category.Sports,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.PressTrustOfIndia,
					Author = "Martin Boyd, Contributor, Martin Boyd, Contributorhttps://www.forbes.com/sites/martinboyd/",
					Title = "Has Blockchain Hit The Wall?",
					Description = "In one stroke, blockchain technology would break down barriers between industry participants and create an infrastructure virtually impervious to fraud.",
					PublishAt = DateTime.Now,
					Content = "Has Blockchain hit the Wall?For investors, fintechs and enterprises thinking about using blockchain, ... there are a number of issues to consider, in addition to return on investmentBLOOMBERG N… [+6271 chars]",
					Category = Category.Sports,
					Priority = Priority.High,
				},
				new News()
				{
					SourceName = Source.Internal,
					Author = "Editorial Team",
					Title = "FCA measures spike in consumer uptake of cryptocurrencies",
					Description = "An estimated 2.6 million UK consumers have bought cryptoassets at some point, new FCA research reveals, almost double the number reported last year.",
					PublishAt = DateTime.Now,
					Content = "An estimated 2.6 million UK consumers have bought cryptoassets at some point, new FCA research reveals, almost double the number reported last year.The research, conducted among 2681 consumers by Y… [+1635 chars]",
					Category = Category.Political,
					Priority = Priority.High,
				},
			};

			return news.Where(n => n.SourceName == source).ToList();
		}
	}
}
