using bri4iparts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bri4iparts.Data.Repositories
{
	public class OrderRepository
	{
		private readonly bri4iPartsContext context;

		public OrderRepository(bri4iPartsContext context)
		{
			this.context = context;
		}

		public async Task<List<Order>> GetAllAsync()
		{
			return await context.Orders.ToListAsync();
		}

		public async Task Add(Order entity)
		{
			await context.Orders.AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(Order entity)
		{
			var foundEntity = await GetById(entity.Id);
			
			foundEntity.ShipmentDate = entity.ShipmentDate;
			foundEntity.ShipmentAddress = entity.ShipmentAddress;

			await context.SaveChangesAsync();
		}

		public async Task<Order> GetById(int id)
		{
			return await context.Orders.FindAsync(id);
		}

		public async Task<Order> Delete(int id)
		{
			Order order = await GetById(id);
			context.Orders.Remove(order);

			await context.SaveChangesAsync();
			return order;
		}
	}
}
