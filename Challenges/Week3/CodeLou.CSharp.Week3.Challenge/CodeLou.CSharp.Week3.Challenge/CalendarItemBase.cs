using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public abstract class CalendarItemBase
	{
		public int Id { get; set; }
        public abstract DateTime StartDateTime { get; set; }
        public abstract DateTime EndDateTime { get; set; }
        public abstract string Location { get; set; }
    }
}
