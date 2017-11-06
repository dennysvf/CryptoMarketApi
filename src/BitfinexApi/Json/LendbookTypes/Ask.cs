﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace Bitfinex.Json.LendbookTypes
{

   public class Ask
   {

      [JsonProperty("rate")]
      public string Rate { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("period")]
      public int Period { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      [JsonProperty("frr")]
      public string Frr { get; set; }

      public override string ToString()
      {
         var str = string.Format("Ask - Rate: {0}, Amount: {1}, Period: {2}, Timestamp: {3}, Frr: {4}",
            Rate, Amount, Period, Timestamp, Frr);
         return str;
      }
   }

}
