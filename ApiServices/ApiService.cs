using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CurrencyCalculator.ApiServices
{
	public class ApiService
	{
		public double GetExchangeRate(string from, string to)
		{
			string json;
			using (var client = new WebClient())
			{
				json = client.DownloadString($"https://v6.exchangerate-api.com/v6/2624dbee2ea5bc75e5b862f0/latest/{from}");
				var data = JObject.Parse(json);
				var rate = (double)data["conversion_rates"][to];
				return rate;
			}

		}
	}
}