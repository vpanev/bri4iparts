using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Parts.Car
{
	public partial class VehicleModifications
	{
		[Parameter] public int Id { get; set; }

		[Inject] private VehicleModificationRepository Repository { get; set; }
		[Inject] private NavigationManager NavigationManager { get; set; }

		private List<VehicleModification> vehicleModifications;
		private List<VehicleModification> sortedData;

		protected override async Task OnInitializedAsync()
		{
			vehicleModifications = await Repository.GetAllAsync(Id);
			if (vehicleModifications.Count > 0)
			{
				sortedData = vehicleModifications;
			}
		}

		protected void OnSelectRow(object row)
		{
			var modification = (VehicleModification)row;
			NavigationManager.NavigateTo($"/productcategory/{modification.Id}");
		}

		protected void SortData(MatSortChangedEvent sort)
		{
			if (!(sort == null || sort.Direction == MatSortDirection.None || string.IsNullOrEmpty(sort.SortId)))
			{
				Comparison<VehicleModification> comparison = null;
				switch (sort.SortId)
				{
					case "cubature":
						comparison = (s1, s2) => s1.Cubature.CompareTo(s2.Cubature);
						break;
					case "horsepower":
						comparison = (s1, s2) => s1.HorsePower.CompareTo(s2.HorsePower);
						break;
					case "kilowats":
						comparison = (s1, s2) => s1.Kilowats.CompareTo(s2.Kilowats);
						break;
					case "year":
						comparison = (s1, s2) => s1.YearOfRelease.CompareTo(s2.YearOfRelease);
						break;
					case "fueltype":
						comparison = (s1, s2) => s1.FuelType.CompareTo(s2.FuelType);
						break;
					case "enginecode":
						comparison = (s1, s2) => s1.EngineCode.CompareTo(s2.EngineCode);
						break;
				}

				if (comparison != null)
				{
					if (sort.Direction == MatSortDirection.Desc)
					{
						sortedData.Sort((s1, s2) => -1 * comparison(s1, s2));
					}
					else
					{
						sortedData.Sort(comparison);
					}
				}
			}
		}
	}
}
