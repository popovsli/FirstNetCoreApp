using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System.Reflection;
using FirstNetCoreMVC.Utils;
using BusinessEntities.Context;
using Microsoft.AspNetCore.Mvc.Razor;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using BusinessEntities.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Security.Claims;
using BusinessEntities.Models.Identity;

namespace FirstNetCoreMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
            Bootstrapper.Run();
        }

        public IConfiguration Configuration { get; }
        private IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //register a filter globally
            services.AddMvc(options =>
            {
                //     options.Filters.Add(new AddHeaderAttribute("GlobalAddHeader",
                //"Result filter added to MvcOptions.Filters")); // an instance
                //     options.Filters.Add(typeof(SampleActionFilter)); // by type

                // Set LocalTest:skipSSL to true to skip SSL requrement in
                // debug mode. This is useful when not using Visual Studio.
                var skipHTTPS = Configuration.GetValue<bool>("LocalTest:skipHTTPS");
                if (Environment.IsDevelopment() && !skipHTTPS)
                {
                    options.Filters.Add(new RequireHttpsAttribute());
                }

                var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()
                            .Build();
                options.Filters.Add(new AuthorizeFilter(policy));

            });

            services.AddAuthorization(option =>
            {
                option.AddPolicy("Admin", policy => policy.RequireClaim(ClaimTypes.Email, "popovsli91@gmail.com").RequireRole("Administrator"));
            });

            //When want to change Area folder name with other name
            //services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.AreaViewLocationFormats.Clear();
            //    options.AreaViewLocationFormats.Add("/Services/{2}/Views/{1}/{0}.cshtml");
            //    options.AreaViewLocationFormats.Add("/Services/{2}/Views/Shared/{0}.cshtml");
            //    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            //});

            services.AddDbContext<MovieContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MovieContext"), x => x.MigrationsAssembly("BusinessEntities")));

            //Identity services are added to the application
            services.AddIdentity<User, Role>()
                //.AddEntityFrameworkStores<MovieContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
                //Allowed characters in the username.
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                // Token settings
                //options.Tokens.ChangeEmailTokenProvider; 

                // Signin settings
                //Prevents registered users from logging in until their email is confirmed.
                options.SignIn.RequireConfirmedEmail = true;
                //options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            //Specify options for Identity for specific user and roletype
            //services.AddIdentity<User, IdentityRole>(options =>
            // {
            //     // Lockout settings
            //     options.Lockout.AllowedForNewUsers = true;
            //     options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //     options.Lockout.MaxFailedAccessAttempts = 5;

            //// Password settings
            //options.Password.RequireDigit = true;
            //options.Password.RequiredLength = 8;
            //options.Password.RequiredUniqueChars = 2;
            //options.Password.RequireLowercase = true;
            //options.Password.RequireNonAlphanumeric = true;
            //options.Password.RequireUppercase = true;

            // })
            // .AddEntityFrameworkStores<MovieContext>()
            // .AddDefaultTokenProviders(); ;

            //It also automatically refreshes the user's claims from the database every refreshInterval if the stamp is unchanged (which takes care of things like changing roles etc)
            //services.Configure<SecurityStampValidatorOptions>(o => o.ValidationInterval = TimeSpan.FromMinutes(10));

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.Name = "AuthenticateCookie";
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);
                options.LoginPath = "/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied

                // ReturnUrlParameter requires `using Microsoft.AspNetCore.Authentication.Cookies;`
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;

                //If set, the provider used by the CookieAuthenticationHandler for data protection.
                //options.DataProtectionProvider 

                //Determines the name of the query string parameter which is appended by the middleware when a 401 Unauthorized status code is changed to a 302 Redirect onto the login path.
                options.ReturnUrlParameter = "ReturnUrl";
            });

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Student API",
                    Version = "v1",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Shayne Boyer", Email = "", Url = "https://twitter.com/spboyer" },
                    License = new License { Name = "Use under LICX", Url = "https://example.com/license" }
                });

                // Set the comments path for the Swagger JSON and UI.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "FirstNetCoreMVC.xml");
                c.IncludeXmlComments(xmlPath);
            });

            services.Configure<AuthMessageSenderOptions>(Configuration);
            services.Configure<GoogleAuthenticationOptions>(Configuration.GetSection("Authentication").GetSection("Google"));

            //Register types for dependancy injection
            //services.AddScoped<IMovieService, MovieService>();
        }

        // ConfigureContainer is where you can register things directly
        // with Autofac. This runs after ConfigureServices so the things
        // here will override registrations made in ConfigureServices.
        // Don't build the container; that gets done for you. If you
        // need a reference to the container, you need to use the
        // "Without ConfigureContainer" mechanism shown later.
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //Register single modul
            //builder.RegisterModule(new ServiceModule());

            //Register all modules in specific Assembly
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            var skipHTTPS = Configuration.GetValue<bool>("LocalTest:skipHTTPS");
            if (Environment.IsDevelopment() && skipHTTPS)
            {
                //Redirects all HTTP requests to HTTPS:
                app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
