namespace bri4iparts.Data.Models
{
	public class Product
	{
		public int Id { get; set; }
		public int ProductCategoryId { get; set; }
		public int ProductManufacturerId { get; set; }
		public int VehicleModificationId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int UnitsInStock { get; set; }
		public string PictureUrl { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }
	}
}
