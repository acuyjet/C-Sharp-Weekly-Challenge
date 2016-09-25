using System;

namespace CodeLou.CSharp.Week3.Challenge
{
    public class Reminder : CalendarItemBase
    {
        public override DateTime StartDateTime { get; set; }
        public DateTime EndDateTime
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

        public string Location
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