using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public class SQLEventRepository : IEventRepository
    {
        private readonly N8Context _context;
        public SQLEventRepository(N8Context context) 
        {
            _context = context;
        }
        public async Task<Event?> GetEventByName(string name)
        {
            return await _context.Events.Where(x => x.Name == name)
                .Include(x => x.Sponsors).FirstAsync();
        }
        public async Task<IEnumerable<Event?>> GetAllEvents()
        {
            return await _context.Events.Where(x => x.Name != null)
                .Include(x => x.Sponsors).ToListAsync();
        }
        public async Task<Event> AddEvent(Event newEvent)
        {
            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();
            return newEvent;
        }
    }
}
