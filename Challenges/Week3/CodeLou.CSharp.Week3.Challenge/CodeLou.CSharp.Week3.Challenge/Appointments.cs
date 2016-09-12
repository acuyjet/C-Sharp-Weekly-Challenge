using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    public class Appointments : CalendarItemBase
    {
        public override DateTime StartDateTime { get; set; }
        public override DateTime EndDateTime { get; set; }
        public override string Location { get; set; }
    }
}