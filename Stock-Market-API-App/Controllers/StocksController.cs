using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Serialization.Json;
using Newtonsoft.Json;
using System.Data;
using static Stock_Market_API_App.Models.StocksViewModel;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stock_Market_API_App.Controllers
{
    public class StocksController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var client = new RestClient("https://www.alphavantage.co");

            RestRequest request = new RestRequest("query?function=SYMBOL_SEARCH&keywords=BA&apikey=demo", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            var content = response.Content;

            JObject json = JObject.Parse(content);
            List<JToken> results = json["bestMatches"].Children().ToList();

            List<StockInfo> stockResults = new List<StockInfo>();
            foreach(JToken result in results)
            {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                StockInfo searchResult = result.ToObject<StockInfo>();
                stockResults.Add(searchResult);
            }

            return View(stockResults);
        }
        public IActionResult FiveMinuteIntraday()
        {
            var client = new RestClient("https://www.alphavantage.co");

            var request = new RestRequest("query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=5min&apikey=demo", DataFormat.Json);

            var response = client.Get(request);

            var content = response.Content;

            JObject json = JObject.Parse(content);
            List<JToken> results = json["Time Series (5min)"].Children().ToList();

            return View();
        }
    }
}
