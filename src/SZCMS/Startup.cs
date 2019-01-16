using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SyZero.Application;
using SyZero.Domain.DomainService;
using SyZero.Domain.Interface;
using SyZero.Infrastructure.EntityFramework;
using SyZero.Infrastructure.Repository;

namespace SZCMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //添加session
            services.AddDistributedMemoryCache();
            services.AddSession();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //添加对AutoMapper的支持
            services.AddAutoMapper();

            services.AddDbContext<SyDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("sqlConnection")));


            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));   //注册数据持久

            var builder = new ContainerBuilder();//实例化 AutoFac  容器 
            //InstancePerLifetimeScope：同一个Lifetime生成的对象是同一个实例
            //SingleInstance：单例模式，每次调用，都会使用同一个实例化的对象；每次都用同一个对象；
            //InstancePerDependency：默认模式，每次调用，都会重新实例化对象；每次请求都创建一个新的对象

            builder.Populate(services);
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//注册仓储泛型

            var assemblys = Assembly.Load("SyZero.Domain.DomainService");//Service是继承接口的实现方法类库名称
            var baseType = typeof(IDependency);//IDependency 是一个接口（所有要实现依赖注入的借口都要继承该接口）
            builder.RegisterAssemblyTypes(assemblys)
                .Where(m => baseType.IsAssignableFrom(m) && m != baseType)
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            var assemblys1 = Assembly.Load("SyZero.Application");//Service是继承接口的实现方法类库名称
            var baseType1 = typeof(IBaseService);//IDependency 是一个接口（所有要实现依赖注入的借口都要继承该接口）
            builder.RegisterAssemblyTypes(assemblys1)
                .Where(m => baseType1.IsAssignableFrom(m) && m != baseType1)
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer);//第三方IOC接管 core内置DI容器

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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseSession(); //加上这句才能用session

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
