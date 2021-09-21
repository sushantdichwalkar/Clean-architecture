using CmScreen.Application.Interfaces;
using CmScreen.Application.Services;
using CmScreen.Domain.Interfaces;
using CmScreen.Infra.Data.Repository;
using LoggerService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IBookService, BookService>();
            services.AddSingleton<ILoggerManager, LoggerManager>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
