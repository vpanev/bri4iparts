using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class VehicleModelRepository
	{
		private readonly bri4iPartsContext context;

		public VehicleModelRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<VehicleModel>> GetAllAsync()
		{
			return await context.VehicleModels.ToListAsync();
		}

		public async Task<List<VehicleModel>> GetAllAsync(int id)
		{
			return await context.VehicleModels.Where(x => x.VehicleBrandId == id).ToListAsync();
		}

		public async Task Add(VehicleModel entity)
		{
			await context.VehicleModels.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(VehicleModel entity)
		{
			var foundEntity = await GetById(entity.Id);

			foundEntity.Name = entity.Name;
			foundEntity.YearOfRelease = entity.YearOfRelease;
			foundEntity.YearOfEnd = entity.YearOfEnd;
			foundEntity.VehicleBrandId = entity.VehicleBrandId;
			foundEntity.PictureUrl = entity.PictureUrl;
			foundEntity.VehicleBrandModelId = entity.VehicleBrandModelId;

			await context.SaveChangesAsync();
		}

		public async Task<VehicleModel> GetById(int id)
		{
			return await context.VehicleModels.FindAsync(id);
		}

		public async Task<VehicleModel> Delete(int id)
		{
			VehicleModel model = await GetById(id);
			context.VehicleModels.Remove(model);

			await context.SaveChangesAsync();
			return model;
		}
	}
}
