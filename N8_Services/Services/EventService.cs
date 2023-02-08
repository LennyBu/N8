using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Services.Services
{
    public class EventService
    {
        private readonly IEventRepository eventrepository;
        public EventService(IEventRepository eventrepository) 
        {
            this.eventrepository = eventrepository;
        }
        public async Task<Event?> GetEventByName(string name)
        {
            return await eventrepository.GetEventByName(name);
        }
        public async Task<IEnumerable<Event?>> GetAllEvents()
        {
            return await eventrepository.GetAllEvents();
        }
        public async Task<Event?> AddEvent(Event newEvent)
        {
            return await eventrepository.AddEvent(newEvent);
        }
    }
}
