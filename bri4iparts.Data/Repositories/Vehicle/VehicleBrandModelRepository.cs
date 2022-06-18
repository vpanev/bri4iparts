using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class VehicleBrandModelRepository
	{
		private readonly bri4iPartsContext context;

		public VehicleBrandModelRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<VehicleBrandModel>> GetAllAsync()
		{
			return await context.VehicleBrandModels.ToListAsync();
		}

		public async Task<List<VehicleBrandModel>> GetAllAsync(int id)
		{
			return await context.VehicleBrandModels.Where(x=>x.Id == id).ToListAsync();
		}

		public async Task Add(VehicleBrandModel entity)
		{
			await context.VehicleBrandModels.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(VehicleBrandModel entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;
			foundEntity.PictureUrl = entity.PictureUrl;
			foundEntity.VehicleBrandId = entity.VehicleBrandId;

			await context.SaveChangesAsync();
		}

		public async Task<VehicleBrandModel> GetById(int id)
		{
			return await context.VehicleBrandModels.FindAsync(id);
		}

		public async Task<VehicleBrandModel> Delete(int id)
		{
			VehicleBrandModel model = await GetById(id);
			context.VehicleBrandModels.Remove(model);

			await context.SaveChangesAsync();
			return model;
		}
	}
}
