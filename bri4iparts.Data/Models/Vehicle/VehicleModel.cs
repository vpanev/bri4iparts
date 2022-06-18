namespace bri4iparts.Data.Models
{
	public class VehicleModel
	{
		public int Id { get; set; }
		public int VehicleBrandId { get; set; }
		public int VehicleBrandModelId { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public DateTime YearOfRelease { get; set; }
		public DateTime YearOfEnd { get; set; }

		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual VehicleBrand VehicleBrand { get; set; }
		public virtual VehicleBrandModel VehicleBrandModel { get; set; }
		public virtual ICollection<VehicleModification> VehicleModifications { get; set; }
	}
}
