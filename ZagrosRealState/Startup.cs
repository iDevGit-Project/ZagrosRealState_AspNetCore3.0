using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ZagrosRealState.Common.PublicClasses;
using ZagrosRealState.Data.Interface;
using ZagrosRealState.Data.Models.Data;
using ZagrosRealState.Data.Models.DbContext;
using ZagrosRealState.Data.UnitOfWork;
using ZagrosRealState.SMS.Services;

namespace ZagrosRealState
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ConvertDate>();

            //verify Connection String To app
            services.AddDbContext<ApplicationDbContext>(option =>
            option.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("StrDBConnection")));

            //verify Idenity service
            services.AddIdentity<ApplicationUsers, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //services.AddIdentity<ApplicationUsers, ApplicationRoles>(option =>
            //{
            //    option.Password.RequireDigit = false;
            //    option.Password.RequireNonAlphanumeric = false;
            //    option.Password.RequireUppercase = false;
            //    option.Password.RequireLowercase = false;
            //})
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            //Session Service
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
            });

            //UnitOfWork Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Persian DateTime Services
            services.AddTransient<ConvertDate>();

            // Send SMS Kanehnegar Services
            services.AddScoped<ISmsSender, SMSSender>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(routes =>
            {
                routes.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapControllerRoute(
                 name: "default",
                 pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
