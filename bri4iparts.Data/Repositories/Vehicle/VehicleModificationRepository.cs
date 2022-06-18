using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class VehicleModificationRepository
	{
		private readonly bri4iPartsContext context;

		public VehicleModificationRepository(bri4iPartsContext context)
		{
			this.context = context;
		}
		public async Task<List<VehicleModification>> GetAllAsync()
		{
			return await context.VehicleModifications.ToListAsync();
		}

		public async Task<List<VehicleModification>> GetAllAsync(int modelId)
		{
			return await context.VehicleModifications.Where(x=>x.VehicleModelId == modelId).ToListAsync();
		}

		public async Task Add(VehicleModification entity)
		{
			await context.VehicleModifications.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(VehicleModification entity)
		{
			var foundEntity = await GetById(entity.Id);
			
			foundEntity.ModifiedOn_18118039 = DateTime.Now;
			foundEntity.Cubature = entity.Cubature;
			foundEntity.FuelType = entity.FuelType;
			foundEntity.HorsePower = entity.HorsePower;
			await context.SaveChangesAsync();
		}

		public async Task<VehicleModification> GetById(int id)
		{
			return await context.VehicleModifications.FindAsync(id);
		}

		public async Task<VehicleModification> Delete(int id)
		{
			VehicleModification modification = await GetById(id);
			context.VehicleModifications.Remove(modification);

			await context.SaveChangesAsync();
			return modification;
		}
	}
}
