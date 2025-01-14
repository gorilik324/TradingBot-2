﻿using Microsoft.Extensions.DependencyInjection;

namespace TradingBot.HttpClients.ByBit
{
    internal static class Configure
    {
        public static void AddByBitHttpClients(this IServiceCollection services)
        {
            services.AddSingleton<AccountHttpClient>();
            services.AddSingleton<MarketHttpClient>();

            services.AddSingleton<ByBitHttpContext>();
        }
    }
}
