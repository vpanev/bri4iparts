namespace bri4iparts.Data.Models
{
	public class ProductSubCategory
	{
		public int Id { get; set; }
		public int ProductCategoryId { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual ProductCategory ProductCategory { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
