using Microsoft.AspNetCore.Identity;

namespace bri4iparts.Data.Models
{
	public class Customer : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual ICollection<Order> Orders { get; set; }
	}
}
