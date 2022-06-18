using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Car
{
	public partial class VehicleBrandModels
	{
		[Parameter]
		public int Id { get; set; }

		[Inject]
		private VehicleBrandModelRepository Repository { get; set; }

		private List<VehicleBrandModel> vehicleBrandModels;
		protected override async Task OnInitializedAsync()
		{
			vehicleBrandModels = await Repository.GetAllAsync(Id);

			// vehicleBrandModels = response
			// 	.Where(x => x.VehicleBrandId == Id)
			// 	.ToList();
		}
	}
}
