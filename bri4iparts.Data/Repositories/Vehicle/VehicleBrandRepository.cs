using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class VehicleBrandRepository
	{
		private readonly bri4iPartsContext context;

		public VehicleBrandRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<VehicleBrand>> GetAllAsync()
		{
			return await context.VehicleBrands.ToListAsync();
		}

		public async Task Add(VehicleBrand entity)
		{
			await context.VehicleBrands.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(VehicleBrand entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;
			foundEntity.VehicleCategoryId = entity.VehicleCategoryId;

			await context.SaveChangesAsync();
		}

		public async Task<VehicleBrand> GetById(int id)
		{
			return await context.VehicleBrands.FindAsync(id);
		}

		public async Task<VehicleBrand> Delete(int id)
		{
			VehicleBrand brand = await GetById(id);
			context.VehicleBrands.Remove(brand);

			await context.SaveChangesAsync();
			return brand;
		}
	}
}
