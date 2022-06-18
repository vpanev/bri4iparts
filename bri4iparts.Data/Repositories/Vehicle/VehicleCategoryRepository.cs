using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class VehicleCategoryRepository
	{
		private readonly bri4iPartsContext context;

		public VehicleCategoryRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<VehicleCategory>> GetAllAsync()
		{
			return await context.VehicleCategories.ToListAsync();
		}

		public async Task Add(VehicleCategory entity)
		{
			await context.VehicleCategories.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(VehicleCategory entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;

			await context.SaveChangesAsync();
		}

		public async Task<VehicleCategory> GetById(int id)
		{
			return await context.VehicleCategories.FindAsync(id);
		}

		public async Task<VehicleCategory> Delete(int id)
		{
			VehicleCategory category = await GetById(id);
			context.VehicleCategories.Remove(category);

			await context.SaveChangesAsync();
			return category;
		}
	}
}
