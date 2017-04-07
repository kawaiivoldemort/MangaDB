using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MangaDB
{
    public class Startup
    {
        public static string envPath;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            envPath = env.WebRootPath;
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}",
                    defaults: new { action = "Homepage" });
                routes.MapRoute(
                    name: "mangaList",
                    template: "{controller=MangaList}",
                    defaults: new { action = "MangaListPage" });
                routes.MapRoute(
                    name: "mangaSummary",
                    template: "{controller=Manga}/{mangaName}/summary.aspx",
                    defaults: new { action = "GetMangaSummary" });
                routes.MapRoute(
                    name: "mangaMetaData",
                    template: "{controller=Manga}/{mangaName}/metadata.aspx",
                    defaults: new { action = "GetMangaMetadata" });
                routes.MapRoute(
                    name: "mangaChapters",
                    template: "{controller=Manga}/{mangaName}/chapters.aspx",
                    defaults: new { action = "GetMangaChapters" });
                routes.MapRoute(
                    name: "manga",
                    template: "{controller=Manga}/{mangaName}/index.aspx",
                    defaults: new { action = "MangaPage" });
                routes.MapRoute(
                    name: "getComments",
                    template: "{controller=GetComments}/{mangaName}/{lastUpdated:int}",
                    defaults: new { action = "GetCommentsAsync" });
                routes.MapRoute(
                    name: "comments",
                    template: "{controller=Comments}/{mangaName}",
                    defaults: new { action = "Comments" });
            });
        }
    }
}
