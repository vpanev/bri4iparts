using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class ProductCategoryRepository
	{
		private readonly bri4iPartsContext context;

		public ProductCategoryRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<ProductCategory>> GetAllAsync()
		{
			return await context.ProductCategories.ToListAsync();
		}

		public async Task Add(ProductCategory entity)
		{
			await context.ProductCategories.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(ProductCategory entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;
			foundEntity.PictureUrl = entity.PictureUrl;

			await context.SaveChangesAsync();
		}

		public async Task<ProductCategory> GetById(int id)
		{
			return await context.ProductCategories.FindAsync(id);
		}

		public async Task<ProductCategory> Delete(int id)
		{
			ProductCategory category = await GetById(id);
			context.ProductCategories.Remove(category);

			await context.SaveChangesAsync();
			return category;
		}
	}
}
