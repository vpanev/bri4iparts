namespace bri4iparts.Data.Models
{
	public class VehicleCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual ICollection<VehicleBrand> VehicleBrands { get; set; }
	}
}
