﻿using AviaTour.Application.UseCases.AuthService;
using AviaTour.Application.UseCases.Extensions.EmailSenderService;
using AviaTour.Application.UseCases.Extensions.TelegramSenderService;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Telegram.Bot;

namespace AviaTour.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEmailSender, EmailSender>();

            services.AddSingleton<TelegramBotClient>(provider =>
            {
                var botToken = $"7317269448:AAEcfzvaG-SgA5TCprIH6-pGhv1za2aMeZ0";
                return new TelegramBotClient(botToken);
            });

            services.AddSingleton<IWriteToTelegramBotService, WriteToTelegramBotService>();
            
            return services;
        }
    }
}
