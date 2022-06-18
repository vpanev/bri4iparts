using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using bri4iparts.Data;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Pages.Parts.Products
{
	public partial class Products
	{
		[Parameter]
		public int ModificationId { get; set; }

		[Parameter]
		public int SubCategoryId { get; set; }

		[Inject]
		private ProductRepository Repository { get; set; }

		[Inject]
		private VehicleModelRepository VehicleModelRepository { get; set; }

		[Inject]
		private VehicleModificationRepository VehicleModificationRepository { get; set; }

		[Inject]
		private ProductManufacturerRepository ProductManufacturerRepository { get; set; }

		[Inject]
		private VehicleBrandRepository VehicleBrandRepository { get; set; }

		[Inject]
		private OrderRepository OrderRepository { get; set; }

		[Inject]
		private IHttpContextAccessor HttpContextAccessor { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		[Inject]
		private bri4iPartsContext dbContext { get; set; }

		private List<Product> products;
		private List<Product> filteredProducts;
		private VehicleModel chosenModel;
		private VehicleModification modification;
		private VehicleBrand vehicleBrand;

		IEnumerable<string> selectedManufacturers = new string[] { };
		private List<string> manufacturers = new();
		private int sortOption;

		private int minPrice = 0;
		private int maxPrice = 1000;

		protected override async Task OnInitializedAsync()
		{
			products = await Repository.GetAllAsync();
			foreach (var product in products)
			{
				product.ProductManufacturer =
					await ProductManufacturerRepository.GetById(product.ProductManufacturerId);
			}

			filteredProducts = products;
			modification = await VehicleModificationRepository.GetById(ModificationId);
			chosenModel = await VehicleModelRepository.GetById(modification.VehicleModelId);
			vehicleBrand = await VehicleBrandRepository.GetById(chosenModel.VehicleBrandId);

			manufacturers = await (
				from p in dbContext.Set<Product>()
				join m in dbContext.Set<ProductManufacturer>()
					on p.ProductManufacturerId equals m.Id

				// where p.VehicleModificationId == ModificationId

				select m.Name)
				.Distinct()
				.ToListAsync();
		}

		private void OnMaxPriceValueChange(int value)
		{
			maxPrice = value;
			filteredProducts = products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
			OnSortSelectChange();
		}

		private void OnMinPriceValueChange(int value)
		{
			minPrice = value;
			filteredProducts = products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
			OnSortSelectChange();
		}

		private void OnManufacturerChange()
		{
			if (selectedManufacturers.Any())
			{
				filteredProducts = products.Where(x => selectedManufacturers.Contains(x.ProductManufacturer.Name)
				&& x.Price >= minPrice
				&& x.Price <= maxPrice)
					.ToList();
			}
			else
			{
				filteredProducts = products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
			}

			if (sortOption != 0)
			{
				OnSortSelectChange();
			}
		}

		private async void OrderProduct(Product product)
		{
			if (HttpContextAccessor.HttpContext != null)
			{
				if (HttpContextAccessor.HttpContext.User.Identity != null && !HttpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
				{
					NavigationManager.NavigateTo("/login", true);
					return;
				}

				var address = await GetCustomerAddress(HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
				Order order = new Order()
				{
					CustomerId = HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier),
					OrderDate = DateTime.Now,
					ShipmentDate = DateTime.Now.AddDays(2),
					ProductId = product.Id,
					ShipmentAddress = address,
					CustomerName = HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name),
				};
				await OrderRepository.Add(order);
			}
		}

		private void OnSortSelectChange()
		{
			switch (sortOption)
			{
				case 1:
					filteredProducts.Sort((a,b) => a.Price.CompareTo(b.Price));
					break;
				case 2:
					filteredProducts.Sort((a, b) => -a.Price.CompareTo(b.Price));
					break;
				case 3:

					filteredProducts.Sort((a, b) => a.ModifiedOn_18118039.CompareTo(b.ModifiedOn_18118039));
					break;
			}
		}

		private async Task<string> GetCustomerAddress(string customerId)
		{
			string address = await
				(
					from o in dbContext.Set<Customer>()

					where o.Id == customerId

					select o.Address
				)
				.FirstAsync();

			return address;
		}
	}
}
