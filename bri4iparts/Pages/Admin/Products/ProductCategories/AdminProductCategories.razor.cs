using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace bri4iparts.Pages.Admin.Products.ProductCategories
{
	public partial class AdminProductCategories
	{
		[Inject]
		public ProductCategoryRepository ProductCategoryRepository { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		[Inject]
		private IJSRuntime JsRuntime { get; set; }


		private List<ProductCategory> productCategories;

		protected override async Task OnInitializedAsync()
		{
			productCategories = await ProductCategoryRepository.GetAllAsync();
		}

		private void AddProductCategory()
		{
			NavigationManager.NavigateTo($"/admin/addproductcategory");
		}

		private void EditProductCategory(ProductCategory category)
		{
			NavigationManager.NavigateTo($"/admin/editproductcategory/{category.Id}");
		}

		private async void DeleteProductCategory(int orderId)
		{
			bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Сигурни ли сте, че искате да изтриете този запис?");
			if (confirmed)
			{
				await ProductCategoryRepository.Delete(orderId);
				productCategories = await ProductCategoryRepository.GetAllAsync();
				StateHasChanged();
			}
		}
	}
}
