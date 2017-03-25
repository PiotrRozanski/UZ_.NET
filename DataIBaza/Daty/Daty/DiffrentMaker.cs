using System;

namespace Daty
{
	public class DiffrentMaker
	{
		private DateTime _date1;
		private DateTime _date2;

		public string SubDate(string beginDate, string endDate, DateType type)
		{
			ParseDate(beginDate, endDate, type);
			return CountDiffrent(_date1, _date2);
		}

		private string CountDiffrent(DateTime first, DateTime second)
		{
			if (first.Date > second.Date)
			{
				var difference12 = first.Date - second.Date;
				var days = (int) difference12.TotalDays;
				return days.ToString();
			}

			var difference21 = second.Subtract(first);
			return difference21.Days.ToString();
		}

		private void ParseDate(string beginDate, string endDate, DateType type)
		{
			var mathTimer = new DateObject
			{
				Date1 = beginDate,
				Date2 = endDate,
				Datetype = type
			};
			switch (mathTimer.Datetype)
			{
				case DateType.Kropka:
					_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy.MM.dd", null);
					_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy.MM.dd", null);
					break;

				case DateType.Myslnik:
					_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy-MM-dd", null);
					_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy-MM-dd", null);
					break;

				case DateType.Ukosnik:
					_date1 = DateTime.ParseExact(mathTimer.Date1, "yyyy/MM/dd", null);
					_date2 = DateTime.ParseExact(mathTimer.Date2, "yyyy/MM/dd", null);
					break;
			}
		}
	}
}