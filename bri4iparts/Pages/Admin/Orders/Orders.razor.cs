using System.Collections.Generic;
using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace bri4iparts.Pages.Admin.Orders
{
	public partial class Orders
	{
		[Inject]
		private OrderRepository OrderRepository { get; set; }

		[Inject]
		private IJSRuntime JsRuntime { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		private List<Order> orders;

		protected override async Task OnInitializedAsync()
		{
			orders = await OrderRepository.GetAllAsync();
		}

		private void EditOrder(Order order)
		{
			NavigationManager.NavigateTo($"/editorder/{order.Id}");
		}
		private async void DeleteOrder(int orderId)
		{
			bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Сигурни ли сте, че искате да изтриете този запис?");
			if (confirmed)
			{
				await OrderRepository.Delete(orderId);
				orders = await OrderRepository.GetAllAsync();
				StateHasChanged();
			}
		}
	}
}
