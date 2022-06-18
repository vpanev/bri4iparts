using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace bri4iparts.Pages.Admin.Products.ProductManufacturers
{
	public partial class AdminProductManufacturers
	{
		[Inject]
		public ProductManufacturerRepository ProductManufacturerRepository { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		[Inject]
		private IJSRuntime JsRuntime { get; set; }


		private List<ProductManufacturer> manufacturers;

		protected override async Task OnInitializedAsync()
		{
			manufacturers = await ProductManufacturerRepository.GetAllAsync();
		}

		private void AddProductManufacturer()
		{
			NavigationManager.NavigateTo($"/admin/addproductmanufacturer");
		}

		private void EditProductManufacturer(ProductManufacturer manufacturer)
		{
			NavigationManager.NavigateTo($"/admin/editproductmanufacturer/{manufacturer.Id}");
		}

		private async void DeleteProductManufacturer(int manufacturerId)
		{
			bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Сигурни ли сте, че искате да изтриете този запис?");
			if (confirmed)
			{
				await ProductManufacturerRepository.Delete(manufacturerId);
				manufacturers = await ProductManufacturerRepository.GetAllAsync();
				StateHasChanged();
			}
		}
	}
}
