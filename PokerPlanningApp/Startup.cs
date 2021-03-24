using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PokerPlanningApp.Extensions.Add;
using PokerPlanningApp.Extensions.Use;
using Newtonsoft.Json;
using PokerPlanningApp.RealTime.Hubs.Classe;

namespace PokerPlanningApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostEnvironment _currentEnvironment { get; }
        public Startup(IConfiguration configuration, IHostEnvironment currentEnvironment)
        {
            Configuration = configuration;
            _currentEnvironment = currentEnvironment;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers()
                    .AddNewtonsoftJson(option => {
                        option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        option.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                        option.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                    });;
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PokerPlanningApp", Version = "v1" });
            });
            services.AddConnection(Configuration, _currentEnvironment);
            services.AddJWT(Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddCORS(Configuration);
            services.AddSERVICES(Configuration, _currentEnvironment);
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PokerPlanningApp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCORS(Configuration);
            app.UseJWT();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<RealTimeHub>("/realtimehub");
                endpoints.MapControllers();
            });
        }
    }
}
