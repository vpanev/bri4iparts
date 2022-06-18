using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Products
{
	public partial class ProductCategory
	{
		[Parameter]
		public int ModificationId { get; set; }

		[Inject]
		private ProductCategoryRepository Repository { get; set; }

		private List<Data.Models.ProductCategory> categories;
		protected override async Task OnInitializedAsync()
		{
			categories = await Repository.GetAllAsync();
		}
	}
}
