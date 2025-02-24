namespace NerdStore.WebApp.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });

            #region

            //builder.Configuration
            //    .SetBasePath(builder.Environment.ContentRootPath)
            //    .AddJsonFile("appsettings.json", true, true)
            //    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
            //    .AddEnvironmentVariables();

            //// Add services to the container.
            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            //builder.Services.AddDbContext<CatalogoContext>(options =>
            //    options.UseSqlServer(connectionString));

            //builder.Services.AddDbContext<VendasContext>(options =>
            //    options.UseSqlServer(connectionString));

            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services.AddDefaultIdentity<IdentityUser>(
            //    options => {
            //        options.SignIn.RequireConfirmedAccount = false;
            //    }).AddEntityFrameworkStores<ApplicationDbContext>();

            //builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

            //builder.Services.AddControllersWithViews();

            //builder.Services.AddHttpContextAccessor();

            //builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));

            //builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            //builder.Services.RegisterServices();

            //builder.Services.AddEndpointsApiExplorer();

            //builder.Services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo()
            //    {
            //        Title = "desenvolvedor.io API",
            //        Description = "desenvolvedor.io  API",
            //        Contact = new OpenApiContact() { Name = "Eduardo Pires", Email = "contato@desenvolvedor.io" },
            //        License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/Licenses/MIT") }
            //    });

            //    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //    {
            //        Description = "Insira o token JWT desta maneira: Bearer {seu token}",
            //        Name = "Authorization",
            //        Scheme = "Bearer",
            //        BearerFormat = "JWT",
            //        In = ParameterLocation.Header,
            //        Type = SecuritySchemeType.ApiKey
            //    });

            //    c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //    {
            //        {
            //            new OpenApiSecurityScheme
            //            {
            //                Reference = new OpenApiReference
            //                {
            //                    Type = ReferenceType.SecurityScheme,
            //                    Id = "Bearer"
            //                }
            //            },
            //            new string[] {}
            //        }
            //    });

            //});

            //var app = builder.Build();

            //var cultureInfo = new CultureInfo("en-US");
            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            //// Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseMigrationsEndPoint();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Vitrine}/{action=Index}/{id?}");
            //app.MapRazorPages();

            //app.UseSwagger();
            //app.UseSwaggerUI(s =>
            //{
            //    s.SwaggerEndpoint("/swagger/v1/swagger.json", "desenvolvedor.io API v1.0");
            //});

            //app.Run();
            #endregion
       
    }
}