using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Data;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.Services;

namespace WebAppMvcPeoples
{
    public class Startup
    {// Step 4
        public Startup(IConfiguration configuration)
        {// jason appsetting
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {// Step 5
            services.AddDbContext<PeopleDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Step 6
            //services.AddScoped<IPeopleRepo, InMemoryPeopleRepo>();
            services.AddScoped<IPeopleRepo, DatabasPeopleRepo>();// IoC & DI
            services.AddScoped<IPeopleService, PeopleService>();// IoC & DI

            //services.AddScoped<ICityRepo, DatabasPeopleRepo>();// IoC & DI
            //services.AddScoped<ICityService, CityService>();// IoC & DI

            //services.AddScoped<ICountryRepo, DatabasPeopleRepo>();// IoC & DI
            //services.AddScoped<ICountryService, CountryService>();// IoC & DI

            //services.AddControllersWithViews(); //Will be used later maybe
            services.AddMvc().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); // for the static files like jsvascript css and more

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
