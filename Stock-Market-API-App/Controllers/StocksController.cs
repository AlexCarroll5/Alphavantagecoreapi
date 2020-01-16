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
            // function, symbol, interval, apikey
            // keyword, from_currency, to_currency
            // from_symbol, to_symbol
            // market
            //time_period, series_type
            const string apikey = "N35AW0V3OLU4VFYP";
            string keyword = "W";
            string function = "SYMBOL_SEARCH";
            string symbol = "";
            string interval = "";
            string from_currency = "";
            string to_currency = "";
            string from_symbol = "";
            string to_symbol = "";
            string market = "";
            string time_period = "";
            string series_type = "";

            //RestRequest request = new RestRequest("query?function=SYMBOL_SEARCH&keywords=BA&apikey=demo", Method.GET);
            RestRequest request = new RestRequest("query?", Method.GET);
            
            request.AddParameter("apikey", apikey);
            request.AddParameter("keywords", keyword);
            request.AddParameter("function", function);
            
            request.AddParameter("symbol", symbol);
            request.AddParameter("interval", interval);
            request.AddParameter("from_currency", from_currency);
            request.AddParameter("to_currency", to_currency);
            request.AddParameter("from_symbol", from_symbol);
            request.AddParameter("to_symbol", to_symbol);
            request.AddParameter("market", market);
            request.AddParameter("time_period", time_period);
            request.AddParameter("series_type", series_type);

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
