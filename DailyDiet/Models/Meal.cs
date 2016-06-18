using System;
namespace DailyDiet
{
	public class Meal
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Time { get; set; }
		public string Image  { get; set; }

		// To sort/categorize in a listview
		public int DateSort => Time.Day;
	}
}

