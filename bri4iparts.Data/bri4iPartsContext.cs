using bri4iparts.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data
{
	public class bri4iPartsContext : IdentityDbContext<Customer>
	{
		public bri4iPartsContext(DbContextOptions options) : base(options)
		{
		}
	}
}
