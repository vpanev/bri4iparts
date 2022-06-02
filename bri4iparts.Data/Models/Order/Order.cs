namespace bri4iparts.Data.Models
{
	internal class Order
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int ProductId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ShipmentDate { get; set; }
		public string CustomerShipmentAddress { get; set; }
		public string CustomerName { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }
	}
}
