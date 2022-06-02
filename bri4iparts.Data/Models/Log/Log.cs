namespace bri4iparts.Data.Models
{
	public class Log
	{
		public int Id { get; set; }
		public DateTime ChangeDate { get; set; }
		public string Command { get; set; }
		public string Table { get; set; }
	}
}
