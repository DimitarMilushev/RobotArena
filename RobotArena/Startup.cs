using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RobotArena.Models;
using AutoMapper;
using RobotArena.Services.RobotServices;
using RobotArena.Services.RobotServices.Interfaces;
using RobotArena.Services.ArmorServices.Interfaces;
using RobotArena.Services.ArmorServices;
using RobotArena.Services.WeaponServices.Interfaces;
using RobotArena.Services.CreepServices.Interfaces;
using RobotArena.Services.WeaponServices;
using RobotArena.Services.CreepServices;

namespace RobotArena
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddDbContext<RobotContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("Robot")));
            services
                .AddIdentity<User, IdentityRole>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<RobotContext>();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId ="1388625917906496";
                facebookOptions.AppSecret = "d1198ba2a96ab29314e17cefa416c0b6";
            });
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = "502775552441-l9mobbpf2osoiru7e652i0saefvjgstj.apps.googleusercontent.com";
                googleOptions.ClientSecret ="cemylM-t3iFA1pjXUiiPOY0q";
            });
            services.AddAutoMapper();
            RegisterServiceLayer(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "area",
                      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private static void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IRobotDataService, RobotDataService>();
            services.AddScoped<IArmorDataService, ArmorDataService>();
            services.AddScoped<IWeaponDataService, WeaponDataService>();
            services.AddScoped<ICreepDataService, CreepDataService>();
        }
    }
}
