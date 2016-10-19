using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    class AppointmentRepository : ICalendarItemRepository<Appointment>
    {
        private readonly Dictionary<int, Appointment> _dictionary;

        public AppointmentRepository()
        {
            _dictionary = new Dictionary<int, Appointment>();
        }

        public void Delete(Appointment item)
        {
            _dictionary[item.Id] = null;
        }

        public IEnumerable<Appointment> FindByDate(DateTime date)
        {
            return GetAllItems().Where(item => item.StartDateTime.Date == date.Date);
        }

        public Appointment FindById(int id)
        {
            //find id in dictionary
            foreach (var currentId in _dictionary.Keys)
            {
                if (_dictionary.ContainsKey(id))
                {
                    return _dictionary[id];
                }
            }

            //return reminder corresponding to that id

            return _dictionary[id];
        }

        public IEnumerable<Appointment> GetAllItems()
        {
            return _dictionary.Values.Cast<Appointment>();
        }

        public void LoadFromJson(string json)
        {
            var dictionary = JsonConvert.DeserializeObject<Dictionary<int, Appointment>>(json);
            foreach (var item in dictionary)
            {
                //This will add or update an item
                _dictionary[item.Key] = item.Value;
            }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(_dictionary, Formatting.Indented);
        }

        public Appointment Update(Appointment item)
        {
            _dictionary[item.Id] = item;
            return item;
        }
    }
}
