namespace bri4iparts.Data.Models
{
	public class VehicleModification
	{
		public int Id { get; set; }
		public int VehicleModelId { get; set; }
		public int Cubature { get; set; }
		public int HorsePower { get; set; }
		public int Kilowats { get; set; }
		public string FuelType { get; set; }
		public string EngineCode { get; set; }
		public DateTime YearOfRelease { get; set; }
		public DateTime YearOfEnd { get; set; }
		public DateTime ModifiedOn_18118039 { get; set; }

		//Navigation properties
		public virtual VehicleModel VehicleModel{ get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
