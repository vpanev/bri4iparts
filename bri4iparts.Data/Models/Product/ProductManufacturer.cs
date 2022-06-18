namespace bri4iparts.Data.Models
{
	public class ProductManufacturer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual ICollection<Product> Products { get; set; }
	}
}
