using System.IO;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;

namespace bri4iparts.Pages.Admin.Products.ProductManufacturers
{
	public partial class EditProductManufacturer
	{
		[Parameter]
		public int Id { get; set; }

		[Inject]
		public ProductManufacturerRepository ProductManufacturerRepository { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		[Inject]
		private IWebHostEnvironment Env { get; set; }

		private ProductManufacturer productManufacturer = new();
		IBrowserFile selectedFile;

		protected override async Task OnInitializedAsync()
		{
			productManufacturer = await ProductManufacturerRepository.GetById(Id);
		}

		protected async void OnSubmit()
		{
			if (selectedFile != null)
			{
				Stream stream = selectedFile.OpenReadStream();
				var path = $"{Env.WebRootPath}/images/manufacturers/{selectedFile.Name}";
				FileStream fs = File.Create(path);
				await stream.CopyToAsync(fs);
				stream.Close();
				fs.Close();

				productManufacturer.PictureUrl = selectedFile.Name;
			}

			await ProductManufacturerRepository.Update(productManufacturer);
			NavigationManager.NavigateTo("/admin/productmanufacturers");
			StateHasChanged();
		}

		protected void OnInputFileChange(InputFileChangeEventArgs e)
		{
			selectedFile = e.File;
			StateHasChanged();
		}
	}
}
