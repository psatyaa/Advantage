using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advantage.Data.Context;
using Advantage.Data.UnitOfWork.Implementation;
using Advantage.Data.UnitOfWork.Interface;
using Advantage.Repository.Implementation;
using Advantage.Repository.Interface;
using Advantage.Schema;
using Advantage.Schema.Interface;
using Advantage.Service.Implementation;
using Advantage.Service.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Advantage.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryData");
            });
            InjectDependency(services);
        }

        private static void InjectDependency(IServiceCollection services)
        {
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IApplicationSchema, ApplicationSchema>();
            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
