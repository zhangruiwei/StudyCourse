using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warren.StudyCource.CustomerService.API.Context;

namespace Warren.StudyCource.CustomerService.API
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
            services.AddDbContext<TeacherContext>(options =>
            {

                options.UseMySql(Configuration.GetConnectionString("Mysql"),ServerVersion.AutoDetect(Configuration.GetConnectionString("Mysql")));

            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            InitSqlData(app);
        }

        public void InitSqlData(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<TeacherContext>();

                context.Database.Migrate();

                if (!context.Teachers.Any())
                {
                    context.Teachers.Add(new Models.Teacher
                    {
                        Name = "张三",
                        Age = 17,
                        CreateTime = DateTime.UtcNow,
                        Description = "语文老师"
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
