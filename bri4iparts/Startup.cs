using bri4iparts.Data;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace bri4iparts
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddControllers(o => o.SuppressAsyncSuffixInActionNames = true);

			services.AddDbContext<bri4iPartsContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("AppConnection"),
					b => b.MigrationsAssembly("bri4iparts")));

			services.AddIdentity<Customer, IdentityRole>(options =>
				{
					options.Password.RequireDigit = false;
					options.Password.RequiredLength = 6;
					options.Password.RequireNonAlphanumeric = false;
					options.Password.RequireUppercase = false;
					options.Password.RequireLowercase = false;
					options.User.RequireUniqueEmail = true;
				})
				.AddDefaultTokenProviders()
				.AddDefaultUI()
				.AddEntityFrameworkStores<bri4iPartsContext>();

			services.AddAuthorization(options =>
			{
				options.AddPolicy("UserPolicy", policy => policy.RequireClaim("Role", "User", "Admin"));
				options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("Role", "Admin"));
			});

			services.AddHttpClient();

			services.AddMatBlazor();

			//add vehicle repos
			services.AddScoped<VehicleBrandRepository>();
			services.AddScoped<VehicleModificationRepository>();
			services.AddScoped<VehicleModelRepository>();
			services.AddScoped<VehicleCategoryRepository>();
			services.AddScoped<VehicleBrandModelRepository>();

			//add product repos
			services.AddScoped<ProductRepository>();
			services.AddScoped<ProductManufacturerRepository>();
			services.AddScoped<ProductCategoryRepository>();
			services.AddScoped<ProductSubCategoryRepository>();

			//add order repos
			services.AddScoped<OrderRepository>();

			services.AddHttpContextAccessor();
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
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
