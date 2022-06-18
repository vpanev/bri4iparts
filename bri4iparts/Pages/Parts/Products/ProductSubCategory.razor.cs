using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Products
{
	public partial class ProductSubCategory
	{
		[Parameter]
		public int CategoryId { get; set; }

		[Parameter]
		public int ModificationId { get; set; }

		[Inject]
		private ProductSubCategoryRepository Repository { get; set; }

		private List<Data.Models.ProductSubCategory> subCategories;
		protected override async Task OnInitializedAsync()
		{
			subCategories = await Repository.GetAllAsync(CategoryId);
		}
	}
}
