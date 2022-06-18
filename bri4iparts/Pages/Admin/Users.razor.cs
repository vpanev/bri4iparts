using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bri4iparts.Data;
using bri4iparts.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace bri4iparts.Pages.Admin
{
	public partial class Users
	{
		[Inject]
		private bri4iPartsContext dbContext { get; set; }

		[Inject]
		private IJSRuntime JsRuntime { get; set; }

		[Inject]
		private UserManager<Customer> UserManager { get; set; }

		private List<Customer> users;

		protected override async Task OnInitializedAsync()
		{
			users = await dbContext.Customers.Select(x => x).ToListAsync();
		}

		private async Task MakeUserAdmin(string userId)
		{
			bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Сигурни ли сте, че искате да направите потребителя админ?");
			if (confirmed)
			{
				var user = await UserManager.FindByIdAsync(userId);

				if (user != null)
				{
					var roles = await UserManager.GetRolesAsync(user);
					await UserManager.RemoveFromRolesAsync(user, roles.ToArray());
					await UserManager.AddToRoleAsync(user, "Admin");
					await dbContext.SaveChangesAsync();
				}
				else
				{
					await JsRuntime.InvokeVoidAsync("Потребителя не е намерен!");
				}
			}
		}
	}
}
