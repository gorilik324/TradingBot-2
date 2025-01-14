﻿using Newtonsoft.Json;

namespace TradingBot.HttpClients.ByBit.ResponseModels
{
    public class Ticker
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("lastPrice")]
        public string LastPrice { get; set; }

        [JsonProperty("indexPrice")]
        public string IndexPrice { get; set; }

        [JsonProperty("markPrice")]
        public string MarkPrice { get; set; }

        [JsonProperty("prevPrice24h")]
        public string PrevPrice24h { get; set; }

        [JsonProperty("price24hPcnt")]
        public string Price24hPcnt { get; set; }

        [JsonProperty("highPrice24h")]
        public string HighPrice24h { get; set; }

        [JsonProperty("lowPrice24h")]
        public string LowPrice24h { get; set; }

        [JsonProperty("prevPrice1h")]
        public string PrevPrice1h { get; set; }

        [JsonProperty("openInterest")]
        public string OpenInterest { get; set; }

        [JsonProperty("openInterestValue")]
        public string OpenInterestValue { get; set; }

        [JsonProperty("turnover24h")]
        public string Turnover24h { get; set; }

        [JsonProperty("volume24h")]
        public string Volume24h { get; set; }

        [JsonProperty("fundingRate")]
        public string FundingRate { get; set; }

        [JsonProperty("nextFundingTime")]
        public string NextFundingTime { get; set; }

        [JsonProperty("predictedDeliveryPrice")]
        public string PredictedDeliveryPrice { get; set; }

        [JsonProperty("basisRate")]
        public string BasisRate { get; set; }

        [JsonProperty("deliveryFeeRate")]
        public string DeliveryFeeRate { get; set; }

        [JsonProperty("deliveryTime")]
        public string DeliveryTime { get; set; }

        [JsonProperty("ask1Size")]
        public string Ask1Size { get; set; }

        [JsonProperty("bid1Price")]
        public string Bid1Price { get; set; }

        [JsonProperty("ask1Price")]
        public string Ask1Price { get; set; }

        [JsonProperty("bid1Size")]
        public string Bid1Size { get; set; }

        [JsonProperty("basis")]
        public string Basis { get; set; }

        [JsonProperty("bid1Iv")]
        public string Bid1Iv { get; set; }

        [JsonProperty("ask1Iv")]
        public string Ask1Iv { get; set; }

        [JsonProperty("markIv")]
        public string MarkIv { get; set; }

        [JsonProperty("underlyingPrice")]
        public string UnderlyingPrice { get; set; }

        [JsonProperty("totalVolume")]
        public string TotalVolume { get; set; }

        [JsonProperty("totalTurnover")]
        public string TotalTurnover { get; set; }

        [JsonProperty("delta")]
        public string Delta { get; set; }

        [JsonProperty("gamma")]
        public string Gamma { get; set; }

        [JsonProperty("vega")]
        public string Vega { get; set; }

        [JsonProperty("theta")]
        public string Theta { get; set; }

        [JsonProperty("change24h")]
        public string Change24h { get; set; }

        [JsonProperty("usdIndexPrice")]
        public string UsdIndexPrice { get; set; }
    }
}