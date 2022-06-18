namespace bri4iparts.Data.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string CustomerId { get; set; }
		public string ShipmentAddress { get; set; }
		public string CustomerName { get; set; }
		public int ProductId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ShipmentDate { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual Customer Customer { get; set; }
		public virtual Product Product { get; set; }
	}
}
