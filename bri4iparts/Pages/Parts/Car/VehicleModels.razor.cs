using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Car
{
	public partial class VehicleModels
	{
		[Parameter]
		public int Id { get; set; }

		[Inject]
		private VehicleModelRepository Repository { get; set; }

		private List<VehicleModel> vehicleModels;
		protected override async Task OnInitializedAsync()
		{
			vehicleModels = await Repository.GetAllAsync(Id);

			// vehicleBrandModels = response
			// 	.Where(x => x.VehicleBrandId == Id)
			// 	.ToList();
		}
	}
}
