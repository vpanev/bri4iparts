using System.IO;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;

namespace bri4iparts.Pages.Admin.Products.ProductCategories
{
	public partial class AddProductCategory
	{
		[Inject]
		public ProductCategoryRepository ProductCategoryRepository { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		[Inject]
		private IWebHostEnvironment Env { get; set; }


		private ProductCategory productCategory = new();
		IBrowserFile selectedFile;

		protected async void OnSubmit()
		{
			if (selectedFile != null)
			{
				Stream stream = selectedFile.OpenReadStream();
				var path = $"{Env.WebRootPath}/images/productcategories/{selectedFile.Name}";
				FileStream fs = File.Create(path);
				await stream.CopyToAsync(fs);
				stream.Close();
				fs.Close();

				productCategory.PictureUrl = selectedFile.Name;
			}

			await ProductCategoryRepository.Add(productCategory);
			NavigationManager.NavigateTo("/admin/productcategories");
			StateHasChanged();
		}

		protected void OnInputFileChange(InputFileChangeEventArgs e)
		{
			selectedFile = e.File;
			StateHasChanged();
		}
	}
}
