using InstaGama.Application.AppAmigo.Interfaces;
using InstaGama.Application.AppAmigos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Repositories.IoC.Application
{
    internal class ApplicationBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<IAmigoAppService, AmigoAppService>();

        }
    }
}
