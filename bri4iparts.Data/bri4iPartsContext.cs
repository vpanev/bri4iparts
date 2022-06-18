using bri4iparts.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data
{
	public class bri4iPartsContext : IdentityDbContext<Customer>
	{
		public bri4iPartsContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<VehicleBrand> VehicleBrands { get; set; }
		public DbSet<VehicleCategory> VehicleCategories { get; set; }
		public DbSet<VehicleModel> VehicleModels { get; set; }
		public DbSet<VehicleModification> VehicleModifications { get; set; }
		public DbSet<VehicleBrandModel> VehicleBrandModels { get; set; }

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
		public DbSet<ProductManufacturer> ProductManufacturers { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Log> Logs { get; set; }

		protected override void OnModelCreating(ModelBuilder b)
		{
			b.Entity<VehicleBrand>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasOne(x => x.VehicleCategory)
					.WithMany(x => x.VehicleBrands)
					.HasForeignKey(x => x.VehicleCategoryId);
			});

			b.Entity<VehicleCategory>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);

				e.HasMany(x => x.VehicleBrands)
					.WithOne(x => x.VehicleCategory);
			});

			b.Entity<VehicleBrandModel>(e =>
			{
				e.HasKey(x => x.Id);

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasOne(x => x.VehicleBrand)
					.WithMany(x => x.VehicleBrandModels)
					.HasForeignKey(x => x.VehicleBrandId);
			});

			b.Entity<VehicleModel>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.Property(x => x.YearOfRelease).IsRequired();
				e.Property(x => x.YearOfEnd).IsRequired();

				e.HasOne(x => x.VehicleBrand)
					.WithMany(x => x.VehicleModels)
					.HasForeignKey(x => x.VehicleBrandId)
					.OnDelete(DeleteBehavior.NoAction);

				e.HasMany(x => x.VehicleModifications)
					.WithOne(x => x.VehicleModel)
					.HasForeignKey(x => x.VehicleModelId);

				e.HasOne(x => x.VehicleBrandModel)
					.WithMany(x => x.VehicleModels)
					.HasForeignKey(x => x.VehicleBrandModelId)
					.OnDelete(DeleteBehavior.NoAction);
			});

			b.Entity<VehicleModification>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Cubature).IsRequired();
				e.Property(x => x.HorsePower).IsRequired();
				e.Property(x => x.FuelType).IsRequired().HasMaxLength(10);
				e.Property(x => x.Kilowats).IsRequired();
				e.Property(x => x.EngineCode).IsRequired().HasMaxLength(100);
				e.Property(x => x.YearOfRelease).IsRequired();
				e.Property(x => x.YearOfEnd).IsRequired();

				e.HasOne(x => x.VehicleModel)
					.WithMany(x => x.VehicleModifications)
					.HasForeignKey(x => x.VehicleModelId);
			});

			b.Entity<Product>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.Description).IsRequired().HasMaxLength(256);
				e.Property(x => x.Price).HasColumnType("decimal(10,2)");
				e.Property(x => x.UnitsInStock).IsRequired();
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasOne(x => x.ProductSubCategory)
					.WithMany(x => x.Products)
					.HasForeignKey(x => x.ProductSubCategoryId);

				e.HasOne(x => x.ProductManufacturer)
					.WithMany(x => x.Products)
					.HasForeignKey(x => x.ProductManufacturerId);

				e.HasOne(x => x.VehicleModification)
					.WithMany(x => x.Products)
					.HasForeignKey(x => x.VehicleModificationId);
			});

			b.Entity<ProductCategory>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasMany(x => x.ProductSubCategories)
					.WithOne(x => x.ProductCategory);
			});

			b.Entity<ProductSubCategory>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasOne(x => x.ProductCategory)
					.WithMany(x => x.ProductSubCategories)
					.HasForeignKey(x => x.ProductCategoryId);
			});


			b.Entity<ProductManufacturer>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.Name).IsRequired().HasMaxLength(256);
				e.Property(x => x.PictureUrl).IsRequired().HasMaxLength(256);

				e.HasMany(x => x.Products).WithOne(x => x.ProductManufacturer);
			});

			b.Entity<Order>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.ShipmentAddress).IsRequired().HasMaxLength(256);
				e.Property(x => x.CustomerName).IsRequired().HasMaxLength(256);

				e.Property(x => x.OrderDate).IsRequired();
				e.Property(x => x.ShipmentDate).IsRequired();

				e.HasOne(x => x.Customer)
					.WithMany(x => x.Orders)
					.HasForeignKey(x => x.CustomerId);

				e.HasOne(x => x.Product)
					.WithMany(x => x.Orders)
					.HasForeignKey(x => x.ProductId);
			});

			b.Entity<Customer>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.Property(x => x.FirstName).IsRequired().HasMaxLength(256);
				e.Property(x => x.LastName).IsRequired().HasMaxLength(256);
				e.Property(x => x.Address).IsRequired().HasMaxLength(256);

				e.HasMany(x => x.Orders)
					.WithOne(x => x.Customer)
					.HasForeignKey(x => x.CustomerId);

				e.Ignore(x => x.AccessFailedCount)
					.Ignore(x => x.LockoutEnabled)
					.Ignore(x => x.EmailConfirmed)
					.Ignore(x => x.LockoutEnd)
					.Ignore(x => x.PhoneNumberConfirmed)
					.Ignore(x => x.SecurityStamp)
					.Ignore(x => x.TwoFactorEnabled);
			});

			b.Entity<Log>(e =>
			{
				e.HasKey(x => x.Id);
				e.Property(x => x.Id).ValueGeneratedOnAdd();

				e.ToTable("logs_18118039");
			});

			base.OnModelCreating(b);
			b.Entity<Customer>().ToTable("Customers");
			b.Entity<IdentityRole>().ToTable("Roles");

			b.Entity<VehicleCategory>().HasData(
				new VehicleCategory
				{
					Id = 1,
					Name = "Car",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleCategory
				{
					Id = 2,
					Name = "Truck",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleCategory
				{
					Id = 3,
					Name = "Motorcycle",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<VehicleModification>().HasData(
				new VehicleModification
				{
					Id = 1,
					Cubature = 1600,
					HorsePower = 101,
					VehicleModelId = 1,
					YearOfRelease = new DateTime(1996, 9, 1),
					YearOfEnd = new DateTime(2003, 5, 1),
					Kilowats = 74,
					EngineCode = "AEH",
					FuelType = "Gasoline",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 2,
					Cubature = 1600,
					HorsePower = 102,
					VehicleModelId = 1,
					YearOfRelease = new DateTime(2000, 8, 1),
					YearOfEnd = new DateTime(2003, 5, 1),
					Kilowats = 75,
					EngineCode = "AVU",
					FuelType = "Gasoline",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 3,
					Cubature = 1800,
					HorsePower = 125,
					VehicleModelId = 1,
					YearOfRelease = new DateTime(1996, 9, 1),
					YearOfEnd = new DateTime(2003, 5, 1),
					Kilowats = 92,
					EngineCode = "AGN",
					FuelType = "Gasoline",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 4,
					Cubature = 1900,
					HorsePower = 90,
					VehicleModelId = 1,
					YearOfRelease = new DateTime(1996, 9, 1),
					YearOfEnd = new DateTime(2001, 7, 1),
					Kilowats = 66,
					EngineCode = "AGR",
					FuelType = "Diesel",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 5,
					Cubature = 1900,
					HorsePower = 110,
					VehicleModelId = 1,
					YearOfRelease = new DateTime(1997, 8, 1),
					YearOfEnd = new DateTime(2001, 7, 1),
					Kilowats = 81,
					EngineCode = "AHF",
					FuelType = "Diesel",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 6,
					Cubature = 2800,
					HorsePower = 204,
					VehicleModelId = 4,
					YearOfRelease = new DateTime(1998, 10, 1),
					YearOfEnd = new DateTime(2005, 8, 1),
					Kilowats = 150,
					EngineCode = "M112.922",
					FuelType = "Gasoline",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModification
				{
					Id = 7,
					Cubature = 3200,
					HorsePower = 197,
					VehicleModelId = 4,
					YearOfRelease = new DateTime(1999, 8, 1),
					YearOfEnd = new DateTime(2002, 9, 1),
					Kilowats = 145,
					EngineCode = "OM613.960",
					FuelType = "Diesel",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<VehicleBrand>().HasData(
				new VehicleBrand
				{
					Id = 1,
					Name = "Audi",
					VehicleCategoryId = 1,
					PictureUrl = "audilogo.png"
				},
				new VehicleBrand
				{
					Id = 2,
					Name = "Mercedes",
					VehicleCategoryId = 1,
					PictureUrl = "mercedeslogo.png"
				},
				new VehicleBrand
				{
					Id = 3,
					Name = "Toyota",
					VehicleCategoryId = 1,
					PictureUrl = "toyotalogo.png"
				},
				new VehicleBrand
				{
					Id = 4,
					Name = "Skoda",
					VehicleCategoryId = 1,
					PictureUrl = "skodalogo.png"
				},
				new VehicleBrand
				{
					Id = 5,
					Name = "MAN",
					VehicleCategoryId = 2,
					PictureUrl = "manlogo.png"
				}
			);

			b.Entity<VehicleModel>().HasData(
				new VehicleModel
				{
					Id = 1,
					VehicleBrandId = 1,
					VehicleBrandModelId = 1,
					Name = "Audi A3 8L1",
					PictureUrl = "audia38l.png",
					YearOfRelease = new DateTime(1996, 9, 1),
					YearOfEnd = new DateTime(2006, 9, 1),
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModel
				{
					Id = 2,
					VehicleBrandId = 1,
					VehicleBrandModelId = 1,
					Name = "Audi A3 8P1",
					PictureUrl = "audia38p.png",
					YearOfRelease = new DateTime(2003, 5, 1),
					YearOfEnd = new DateTime(2013, 12, 1),
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModel
				{
					Id = 3,
					VehicleBrandId = 1,
					VehicleBrandModelId = 1,
					Name = "Audi A3 Cabrio",
					PictureUrl = "audicabrio.png",
					YearOfRelease = new DateTime(2008, 4, 1),
					YearOfEnd = new DateTime(2013, 5, 1),
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModel
				{
					Id = 4,
					VehicleBrandId = 2,
					VehicleBrandModelId = 2,
					Name = "Mercedes S-class Saloon W220",
					PictureUrl = "mercedesw220.png",
					YearOfRelease = new DateTime(1998, 9, 1),
					YearOfEnd = new DateTime(2005, 8, 1),
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleModel
				{
					Id = 5,
					VehicleBrandId = 2,
					VehicleBrandModelId = 2,
					Name = "Mercedes S-class Saloon W124",
					PictureUrl = "mercedesw124.png",
					YearOfRelease = new DateTime(1984, 12, 1),
					YearOfEnd = new DateTime(1993, 8, 1),
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<VehicleBrandModel>().HasData(
				new VehicleBrandModel
				{
					Id = 1,
					VehicleBrandId = 1,
					Name = "Audi A3",
					PictureUrl = "audia3.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new VehicleBrandModel
				{
					Id = 2,
					VehicleBrandId = 2,
					Name = "Mercedes S-Class",
					PictureUrl = "mercedessclass.png",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<ProductCategory>().HasData(
				new ProductCategory
				{
					Id = 1,
					Name = "Спирачна система",
					PictureUrl = "brakesystem.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductCategory
				{
					Id = 2,
					Name = "Части за двигател",
					PictureUrl = "engineparts.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductCategory
				{
					Id = 3,
					Name = "Масла и течности",
					PictureUrl = "oil.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductCategory
				{
					Id = 4,
					Name = "Трансмисия",
					PictureUrl = "transmission.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductCategory
				{
					Id = 5,
					Name = "Ремъчно задвижване",
					PictureUrl = "belt.png",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<ProductSubCategory>().HasData(
				new ProductSubCategory
				{
					Id = 1,
					ProductCategoryId = 1,
					Name = "Накладки",
					PictureUrl = "brakes.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 2,
					ProductCategoryId = 1,
					Name = "Спирачни дискове",
					PictureUrl = "brakedisks.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 3,
					ProductCategoryId = 1,
					Name = "Спирачни апарати",
					PictureUrl = "brakeaparats.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 4,
					ProductCategoryId = 2,
					Name = "Клапани",
					PictureUrl = "valves.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 5,
					ProductCategoryId = 2,
					Name = "Разпределителен вал",
					PictureUrl = "camshaft.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 6,
					ProductCategoryId = 2,
					Name = "Повдигачи",
					PictureUrl = "lifters.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 7,
					ProductCategoryId = 3,
					Name = "Моторно масло",
					PictureUrl = "motoroil.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 8,
					ProductCategoryId = 3,
					Name = "Трансмисионно масло",
					PictureUrl = "transmissionoil.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 9,
					ProductCategoryId = 3,
					Name = "Антифриз",
					PictureUrl = "antifreeze.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 10,
					ProductCategoryId = 4,
					Name = "Съединител",
					PictureUrl = "coupler.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id =11,
					ProductCategoryId = 4,
					Name = "Притискателен диск",
					PictureUrl = "couplerdisk.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id =12,
					ProductCategoryId = 5,
					Name = "Пистов ремък",
					PictureUrl = "trackbelt.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductSubCategory
				{
					Id = 13,
					ProductCategoryId = 5,
					Name = "Комплект ангренажен ремък",
					PictureUrl = "timebelt.png",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<ProductManufacturer>().HasData(
				new ProductManufacturer
				{
					Id = 1,
					Name = "Ridex",
					PictureUrl = "ridex.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductManufacturer
				{
					Id = 2,
					Name = "Febi Bilstein",
					PictureUrl = "febibilstein.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductManufacturer
				{
					Id = 3,
					Name = "VALEO",
					PictureUrl = "valeo.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new ProductManufacturer
				{
					Id = 4,
					Name = "Bosch",
					PictureUrl = "bosch.png",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					ProductSubCategoryId = 1,
					ProductManufacturerId = 3,
					VehicleModificationId = 1,
					Name = "Накладки Valeo",
					Description = "накладки",
					Price = 45,
					UnitsInStock = 10,
					PictureUrl = "valeobrakes.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new Product
				{
					Id = 2,
					ProductSubCategoryId = 7,
					ProductManufacturerId = 4,
					VehicleModificationId = 4,
					Name = "Моторно масло Bosch 0w30",
					Description = "моторно масло 0w30",
					Price = 75,
					UnitsInStock = 10,
					PictureUrl = "boschoil.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new Product
				{
					Id = 3,
					ProductSubCategoryId = 12,
					ProductManufacturerId = 4,
					VehicleModificationId = 4,
					Name = "Пистов ремък Bosch",
					Description = "Bosch пистов ремък",
					Price = 15,
					UnitsInStock = 10,
					PictureUrl = "boschbelt.png",
					ModifiedOn_18118039 = DateTime.Now
				},
				new Product
				{
					Id = 4,
					ProductSubCategoryId = 10,
					ProductManufacturerId = 3,
					VehicleModificationId = 5,
					Name = "Съединител Valeo",
					Description = "Съединител Valeo",
					Price = 255,
					UnitsInStock = 20,
					PictureUrl = "valeocoupler.jpg",
					ModifiedOn_18118039 = DateTime.Now
				}
			);

			b.Entity<AppIdentityRole>().HasData(
				new AppIdentityRole
				{
					ConcurrencyStamp = null,
					Id = "1",
					Name = "Admin",
					NormalizedName = "Admin",
					ModifiedOn_18118039 = DateTime.Now
				},
				new AppIdentityRole
				{
					ConcurrencyStamp = null,
					Id = "2",
					Name = "User",
					NormalizedName = "User",
					ModifiedOn_18118039 = DateTime.Now
				},
				new AppIdentityRole
				{
					ConcurrencyStamp = null,
					Id = "3",
					Name = "SuperUser",
					NormalizedName = "SuperUser",
					ModifiedOn_18118039 = DateTime.Now
				});

			b.Entity<AppIdentityUserRole>().HasData(
				new AppIdentityUserRole
				{
					RoleId = "1",
					UserId = "5f398b2d-0efb-488d-aab7-a85a52f86a8a",
					ModifiedOn_18118039 = DateTime.Now
				},
				new AppIdentityUserRole
				{
					RoleId = "2",
					UserId = "41d18d4b-8234-46f3-99e5-8f8a59e49c34",
					ModifiedOn_18118039 = DateTime.Now
				},
				new AppIdentityUserRole
				{
					RoleId = "3",
					UserId = "bb76e669-683a-46c8-b476-b612454880f9",
					ModifiedOn_18118039 = DateTime.Now
				});


			b.Entity<Customer>().HasData(
				new Customer
				{
					Id = "41d18d4b-8234-46f3-99e5-8f8a59e49c34",
					FirstName = "Default",
					LastName = "User",
					Address = "Varna, Bulgaria",
					UserName = "user@gmail.com",
					NormalizedUserName = "USER@GMAIL.COM",
					Email = "user@gmail.com",
					NormalizedEmail = "USER@GMAIL.COM",
					PasswordHash =
						"AQAAAAEAACcQAAAAEDR9G+s28XG5moo8a/IrN/zqBFI8gB9gHwjO8tD4eTIKaVfqtsjE4BOFy5NAPel21A==",
					ConcurrencyStamp = "5dd9f617-acac-4a54-b89d-f0a49c84df24",
					PhoneNumber = "0876564320",
					ModifiedOn_18118039 = DateTime.Now
				},
				new Customer
				{
					Id = "5f398b2d-0efb-488d-aab7-a85a52f86a8a",
					FirstName = "Admin",
					LastName = "User",
					Address = "Sofia, Bulgaria",
					UserName = "admin@gmail.com",
					NormalizedUserName = "ADMIN@GMAIL.COM",
					Email = "ADMIN@gmail.com",
					NormalizedEmail = "ADMIN@GMAIL.COM",
					PasswordHash =
						"AQAAAAEAACcQAAAAEKngcAGKfsb/6o5lrhWCa2ohoNEniI2IQY/vYkk7OO3TUu9dFQvNCNibW/0pW5kNKQ==",
					ConcurrencyStamp = "2ae5e412-2e0b-476a-87ac-3df84ab18aec",
					PhoneNumber = "0878000012",
					ModifiedOn_18118039 = DateTime.Now
				},
				new Customer
				{
					Id = "bb76e669-683a-46c8-b476-b612454880f9",
					FirstName = "Super",
					LastName = "User",
					Address = "Pleven, Bulgaria",
					UserName = "superuser@gmail.com",
					NormalizedUserName = "SUPERUSER@GMAIL.COM",
					Email = "superuser@gmail.com",
					NormalizedEmail = "SUPERUSER@GMAIL.COM",
					PasswordHash =
						"AQAAAAEAACcQAAAAEIUD4cA1MJN1pkLrRZuqIuyefwL0Fp5s84VNX24E1S7B11iyWtcl6/hko9hrsYmMRA==",
					ConcurrencyStamp = "5907ab1e-15b7-4b1a-a2b6-d548057e0c68",
					PhoneNumber = "0878123413",
					ModifiedOn_18118039 = DateTime.Now
				});
		}
	}
}
