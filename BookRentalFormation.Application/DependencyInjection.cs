﻿using BookRentalFormation.Application.Services.RentService;
using Microsoft.Extensions.DependencyInjection;

namespace BookRentalFormation.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRentService, RentService>();

            return services;
        }
    }
}
