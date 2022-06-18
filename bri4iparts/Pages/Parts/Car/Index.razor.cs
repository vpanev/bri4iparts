using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Car
{
	public partial class Index
	{
		[Inject]
		private VehicleBrandRepository VehicleBrandRepository { get; set; }

		private List<VehicleBrand> vehicleBrands;
		protected override async Task OnInitializedAsync()
		{
			var carBrands = await VehicleBrandRepository.GetAllAsync();
			vehicleBrands = carBrands.Where(x => x.VehicleCategoryId == 1).ToList();
		}
	}
}
