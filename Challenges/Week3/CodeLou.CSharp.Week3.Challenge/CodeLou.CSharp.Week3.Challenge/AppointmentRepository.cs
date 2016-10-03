using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    class AppointmentRepository : ICalendarItemRepository<Appointment>
    {
        public void Delete(Appointment item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> FindByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Appointment FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public void LoadFromJson(string json)
        {
            throw new NotImplementedException();
        }

        public string ToJson()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment item)
        {
            throw new NotImplementedException();
        }
    }
}
