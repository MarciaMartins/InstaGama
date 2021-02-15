
using InstaGama.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Repositories.IoC.Repositories
{
    internal class RepositoryBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<IAmigoRepository, AmigoRepository>();
        }
    }
}
