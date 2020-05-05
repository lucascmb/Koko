using AutoMapper;
using Koko.Domain.Models;
using Koko.Domain.Repositories;
using Koko.Domain.Services;
using Koko.Persistence.Contexts;
using Koko.Persistence.Repositories;
using Koko.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

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

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

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

            app.UseCors(
                options => options.WithOrigins("http://localhost:3000").AllowAnyMethod()
            );

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

                var jsonString = File.ReadAllText("MockDB/products.json");

                var products = JsonSerializer.Deserialize<List<Product>>(jsonString);
                context.AddRange(products);

                jsonString = File.ReadAllText("MockDB/clients.json");

                var clients = JsonSerializer.Deserialize<List<Client>>(jsonString);
                    
                for( int i = 0; i < products.Count(); i++)
                {
                    clients[i % clients.Count].Products.Add(products[i]);
                    products[i].Client = clients[i % clients.Count];
                    products[i].ClientId = products[i].Id;
                    clients[i % clients.Count].HeritageAmount += products[i].ValueAmount;
                }

                context.Clients.AddRange(clients);

                jsonString = File.ReadAllText("MockDB/advisors.json");

                var advisors = JsonSerializer.Deserialize<List<Advisor>>(jsonString);

                for( int i = 0; i < clients.Count(); i++ )
                {
                    advisors[i % advisors.Count].ClientAmount++;
                    advisors[i % advisors.Count].Clients.Add(clients[i]);

                    advisors[i % advisors.Count].HeritageAmount += clients[i].HeritageAmount;

                    clients[i].Advisor = advisors[i % advisors.Count];
                    clients[i].AdvisorId = advisors[i % advisors.Count].Id;
                }

                context.Advisors.AddRange(advisors);

                context.SaveChanges();
            }
        }
    }
}
