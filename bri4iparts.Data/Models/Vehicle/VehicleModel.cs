namespace bri4iparts.Data.Models
{
	internal class VehicleModel
	{
		public int Id { get; set; }
		public int VehicleModificationId { get; set; }
		public int VehicleBrandId { get; set; }
		public string Name { get; set; }
		public DateTime YearOfRelease { get; set; }
		public DateTime YearOfEnd { get; set; }

		public DateTime ModifiedOn_18118039 { get; set; }
	}
}
