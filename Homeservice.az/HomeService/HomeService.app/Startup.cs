using Beacon.app.Resources;
using FluentValidation.AspNetCore;
using HomeService.app.ServiceException;
using HomeService.core;
using HomeService.core.Models;
using HomeService.data;
using HomeService.service.Dtos;
using HomeService.service.Implementations;
using HomeService.service.Interfaces;
using HomeService.service.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HomeService.app
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

            services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<SettingPostDto>());
            services.AddControllersWithViews();
            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });

            services.AddMvc()
            .AddViewLocalization()
            .AddDataAnnotationsLocalization(
                opt => opt.DataAnnotationLocalizerProvider = (type, factory) =>
                {
                    var assembliyName = new AssemblyName(typeof(SharedModelResource).GetTypeInfo().Assembly.FullName);
                    return factory.Create(nameof(SharedModelResource), assembliyName.Name);
                }
                );




            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("az-AZ"),
                    new CultureInfo("ru-RU"),

                };
                opt.DefaultRequestCulture = new RequestCulture("en-US");
                opt.SupportedCultures = supportedCultures;
                opt.SupportedUICultures = supportedCultures;

                opt.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new  QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider(),
                    new AcceptLanguageHeaderRequestCultureProvider()
                };
            });

            services.AddControllersWithViews();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IAdvantageService, AdvantageService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICostService, CostService>();
            services.AddScoped<IQuestionServis, QuestionService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IMessageservice, MessageService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<ISeoDescriptionService, SeoDescriptionService>();
            services.AddScoped<ISeoKeyWordService, SeoKeyWordService>();
            services.AddScoped<ISeoTagService, SeoTagService>();

            services.AddDbContext<HomeServiceDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("Default"));

            });
            services.AddIdentity<AppUser, IdentityRole>(option =>
            {

                option.SignIn.RequireConfirmedEmail = false;
                option.User.RequireUniqueEmail = false;
                option.Password.RequireDigit = true;
                option.Password.RequiredLength = 8;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireLowercase = false;
                option.Password.RequireUppercase = false;

                option.Lockout.MaxFailedAccessAttempts = 500;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                option.Lockout.AllowedForNewUsers = true;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<HomeServiceDbContext>();
            services.AddHttpContextAccessor();




            services.AddAutoMapper(opt =>
            {
                opt.AddProfile(new MapProfile());

            });
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

            app.UseCustomExceptionHandler();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=account}/{action=login}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
