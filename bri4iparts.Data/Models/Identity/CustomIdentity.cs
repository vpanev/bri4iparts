using Microsoft.AspNetCore.Identity;

namespace bri4iparts.Data.Models
{
	public class AppIdentityRole : IdentityRole
	{
		public DateTime ModifiedOn_18118039 { get; set; }
	}
	public class AppIdentityUserRole : IdentityUserRole<string>
	{
		public DateTime ModifiedOn_18118039 { get; set; }
	}
}
