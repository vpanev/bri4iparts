using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class ProductSubCategoryRepository
	{
		private readonly bri4iPartsContext context;

		public ProductSubCategoryRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<ProductSubCategory>> GetAllAsync()
		{
			return await context.ProductSubCategories.ToListAsync();
		}

		public async Task<List<ProductSubCategory>> GetAllAsync(int categoryId)
		{
			return await context.ProductSubCategories
				.Where(x=>x.ProductCategoryId == categoryId)
				.ToListAsync();
		}

		public async Task Add(ProductSubCategory entity)
		{
			await context.ProductSubCategories.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(ProductSubCategory entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;

			await context.SaveChangesAsync();
		}

		public async Task<ProductSubCategory> GetById(int id)
		{
			return await context.ProductSubCategories.FindAsync(id);
		}

		public async Task<ProductSubCategory> Delete(int id)
		{
			ProductSubCategory subCategory = await GetById(id);
			context.ProductSubCategories.Remove(subCategory);

			await context.SaveChangesAsync();
			return subCategory;
		}
	}
}
