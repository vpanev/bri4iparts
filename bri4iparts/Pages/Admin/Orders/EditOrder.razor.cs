using System.Threading.Tasks;
using bri4iparts.Data.Models;
using bri4iparts.Data.Repositories;
using Microsoft.AspNetCore.Components;

namespace bri4iparts.Pages.Admin.Orders
{
	public partial class EditOrder
	{
		[Parameter]
		public int Id { get; set; }

		[Inject]
		private OrderRepository OrderRepository { get; set; }

		[Inject]
		private ProductRepository ProductRepository { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		private Order order = new();
		private string productName = "";

		protected override async Task OnInitializedAsync()
		{
			order = await OrderRepository.GetById(Id);
			var product = await ProductRepository.GetById(order.ProductId);
			productName = product.Name;
		}

		protected async Task OnSubmit()
		{
			await OrderRepository.Update(order);
			NavigationManager.NavigateTo("/orders");
		}
	}
}
