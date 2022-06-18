using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class ProductManufacturerRepository
	{
		private readonly bri4iPartsContext context;

		public ProductManufacturerRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<ProductManufacturer>> GetAllAsync()
		{
			return await context.ProductManufacturers.ToListAsync();
		}

		public async Task Add(ProductManufacturer entity)
		{
			await context.ProductManufacturers.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(ProductManufacturer entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;

			await context.SaveChangesAsync();
		}

		public async Task<ProductManufacturer> GetById(int id)
		{
			return await context.ProductManufacturers.FindAsync(id);
		}

		public async Task<ProductManufacturer> Delete(int id)
		{
			ProductManufacturer manufacturer = await GetById(id);
			context.ProductManufacturers.Remove(manufacturer);

			await context.SaveChangesAsync();
			return manufacturer;
		}
	}
}
