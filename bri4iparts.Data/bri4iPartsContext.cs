using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data
{
	public class bri4iPartsContext : DbContext
	{
		public bri4iPartsContext(DbContextOptions options) : base(options)
		{
		}
	}
}
