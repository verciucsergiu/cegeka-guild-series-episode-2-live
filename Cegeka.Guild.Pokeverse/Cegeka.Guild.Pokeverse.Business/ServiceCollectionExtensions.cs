﻿using Cegeka.Guild.Pokeverse.Business.Abstracts;
using Cegeka.Guild.Pokeverse.Business.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Cegeka.Guild.Pokeverse.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            return services.AddScoped<ITrainerService, TrainerService>()
                .AddScoped<IBattleService, BattleService>()
                .AddScoped<IArenaService, ArenaService>();
        }
    }
}