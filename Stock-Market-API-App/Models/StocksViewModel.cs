using System;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;

namespace Stock_Market_API_App.Models
{
    public class StocksViewModel
    {
        public StocksViewModel()
        {

        }
        public class StockInfo
        {
            [JsonProperty("1. symbol")]
            public string Symbol { get; set; }
            [JsonProperty("2. name")]
            public string Name { get; set; }
            [JsonProperty("3. type")]
            public string Type { get; set; }
            [JsonProperty("4. region")]
            public string Region { get; set; }
            [JsonProperty("5. marketOpen")]
            public DateTime MarketOpen { get; set; }
            [JsonProperty("6. marketClose")]
            public DateTime MarketClose { get; set; }
            [JsonProperty("7. timezone")]
            public string TimeZone { get; set; }
            [JsonProperty("8. currency")]
            public string Currency { get; set; }
            [JsonProperty("9. matchScore")]
            public float MatchScore { get; set; }
        }
        public class IntradayStock
        {
            public string Symbol { get; set; }
            public double Open { get; set; }
            public double Close { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
            public double Volume { get; set; }
        }
    }

}
