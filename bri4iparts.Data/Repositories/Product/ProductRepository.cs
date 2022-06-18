using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class ProductRepository
	{
		private readonly bri4iPartsContext context;

		public ProductRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<Product>> GetAllAsync()
		{
			return await context.Products.ToListAsync();
		}

		public async Task<List<Product>> GetAllAsync(int modificationId, int subCategoryId)
		{
			return await context.Products
				.Where(x=>x.VehicleModificationId == modificationId 
				          && x.ProductSubCategoryId == subCategoryId)
				.ToListAsync();
		}

		public async Task Add(Product entity)
		{
			await context.Products.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(Product entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.ProductSubCategoryId = entity.ProductSubCategoryId;
			foundEntity.ProductManufacturerId = entity.ProductManufacturerId;
			foundEntity.VehicleModificationId = entity.VehicleModificationId;
			foundEntity.Name = entity.Name;
			foundEntity.Description = entity.Description;
			foundEntity.Price = entity.Price;

			await context.SaveChangesAsync();
		}

		public async Task<Product> GetById(int id)
		{
			return await context.Products.FindAsync(id);
		}

		public async Task<Product> Delete(int id)
		{
			Product product = await GetById(id);
			context.Products.Remove(product);

			await context.SaveChangesAsync();
			return product;
		}
	}
}
