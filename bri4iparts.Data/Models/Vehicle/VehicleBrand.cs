namespace bri4iparts.Data.Models
{
	public class VehicleBrand
	{
		public int Id { get; set; }
		public int VehicleCategoryId { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }

		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual VehicleCategory VehicleCategory { get; set; }
		public virtual ICollection<VehicleModel> VehicleModels { get; set; }
		public virtual ICollection<VehicleBrandModel> VehicleBrandModels { get; set; }
	}
}
