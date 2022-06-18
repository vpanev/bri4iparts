namespace bri4iparts.Data.Models
{
	public class VehicleBrandModel
	{
		public int Id { get; set; }
		public int VehicleBrandId { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }

		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual VehicleBrand VehicleBrand { get; set; }
		public virtual ICollection<VehicleModel> VehicleModels { get; set; }
	}
}
