using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daty
{
	public class DiffrentMaker
	{
		private DateTime _date1;
		private DateTime _date2;

		public string SubDate(string beginDate, string endDate, DateType type)
		{
			var mathTimer = new MathTimer
			{
				Date1 = beginDate,
				Date2 = endDate,
				Datetype = type
			};
			switch (mathTimer.Datetype)
			{
				case DateType.Dot:
					try
					{
						_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy.MM.dd", null);
						_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy.MM.dd", null);
					}
					catch (ArgumentException e)
					{
						Console.WriteLine(e);
						throw;
					}
					return CountDiffrent(_date1, _date2);
				case DateType.Myslnik:
					try
					{
						_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy-MM-dd", null);
						_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy-MM-dd", null);
					}
					catch (ArgumentException e)
					{
						Console.WriteLine(e);
						throw;
					}
					return CountDiffrent(_date1, _date2);
				case DateType.Ukosnik:
					try
					{
						_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy/MM/dd", null);
						_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy/MM/dd", null);
					}
					catch (ArgumentException e)
					{
						Console.WriteLine(e);
						throw;
					}
					return CountDiffrent(_date1, _date2);
				default:
					return string.Empty;
			}
		}

		private string CountDiffrent(DateTime first, DateTime second)
		{
			if (first.Date > second.Date)
			{
				TimeSpan difference12 = first.Date - second.Date;
				var days = (int)difference12.TotalDays;
				return days.ToString();
			}

			TimeSpan difference21 = second.Subtract(first);
			return difference21.Days.ToString();
		}
	
}
}
