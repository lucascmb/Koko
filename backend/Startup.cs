using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Persistence.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Koko.Domain.Repositories;
using Koko.Domain.Services;
using Koko.Services;
using Koko.Persistence.Repositories;
using AutoMapper;
using Koko.Domain.Models;
using System.IO;
using System.Text.Json;
using Koko.Resources;

namespace Koko
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
            services.AddControllers();

            services.AddDbContext<GorilaDbContext>(options =>
            {
                options.UseInMemoryDatabase("koko-in-memory");
            });

            services.AddScoped<IAdvisorService, AdvisorService>();
            services.AddScoped<IAdvisorRepository, AdvisorRepository>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IInvestorService, InvestorService>();
            services.AddScoped<IInvestorRepository, InvestorRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SeedDatabase();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void SeedDatabase()
        {
            var options = new DbContextOptionsBuilder<GorilaDbContext>().UseInMemoryDatabase(databaseName: "koko-in-memory").Options;

            using (var context = new GorilaDbContext(options))
            {
                context.Database.EnsureCreated();

                var jsonString = File.ReadAllText("MockDB/advisors.json");

                var fund = JsonSerializer.Deserialize<List<Advisor>>(jsonString);
                context.Advisors.AddRange(fund);

                jsonString = File.ReadAllText("MockDB/clients.json");

                //var client = JsonSerializer.Deserialize<List<Client>>(jsonString);
                //context.Clients.AddRange(client);

                context.SaveChanges();
            }
        }
    }
}
