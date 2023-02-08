using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N8_Data.Entities;

namespace N8_Data.Repositories
{
    public interface IEventRepository
    {
        Task<Event?> GetEventByName(string name);
        Task<IEnumerable<Event>> GetAllEvents();
        Task<Event> AddEvent(Event newEvent);
    }
}
