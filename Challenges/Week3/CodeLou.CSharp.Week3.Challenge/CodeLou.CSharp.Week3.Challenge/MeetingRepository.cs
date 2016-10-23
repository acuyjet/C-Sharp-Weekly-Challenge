using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    class MeetingRepository : ICalendarItemRepository<Meeting>
    {
        private readonly Dictionary<int, Meeting> _dictionary;

        public MeetingRepository()
        {
            _dictionary = new Dictionary<int, Meeting>();
        }

        public Meeting Create()
        {
            var nextAvailableId = 0;
            foreach (var currentId in _dictionary.Keys)
            {
                if (nextAvailableId > currentId)
                    continue;
                if (nextAvailableId < currentId)
                    break;

                nextAvailableId++;
            }

            var meeting = new Meeting();
            meeting.Id = nextAvailableId;
            _dictionary.Add(nextAvailableId, new Meeting());

            return meeting;
        }

        public void Delete(Meeting item)
        {
            _dictionary[item.Id] = null;
        }

        public IEnumerable<Meeting> FindByDate(DateTime date)
        {
            return GetAllItems().Where(item => item.StartDateTime.Date == date.Date);
        }

        public Meeting FindById(int id)
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

        public IEnumerable<Meeting> GetAllItems()
        {
            return _dictionary.Values.Cast<Meeting>();
        }

        public void LoadFromJson(string json)
        {
            var dictionary = JsonConvert.DeserializeObject<Dictionary<int, Meeting>>(json);
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

        public Meeting Update(Meeting item)
        {
            _dictionary[item.Id] = item;
            return item;
        }
    }
}
