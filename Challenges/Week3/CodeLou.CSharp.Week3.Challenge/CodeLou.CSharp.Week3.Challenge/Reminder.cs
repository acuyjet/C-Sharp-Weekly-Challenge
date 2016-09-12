using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public class Reminder: CalendarItemBase
	{
        public override DateTime StartDateTime { get; set; }
        public override DateTime EndDateTime
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Location
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

    }
}