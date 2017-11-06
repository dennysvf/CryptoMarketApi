﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace Bitfinex.Json.OrderbookTypes
{
   public class Ask
   {

      [JsonProperty("price")]
      public decimal Price { get; set; }

      [JsonProperty("amount")]
      public decimal Amount { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      public override string ToString()
      {
         var str = string.Format("Ask - Price: {0}, Amount: {1} - Timestamp: {2}", Price, Amount, Timestamp);
         return str;
      }
   }

}
