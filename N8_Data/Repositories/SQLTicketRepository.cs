using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public class SQLTicketRepository : ITicketRepository
    {
        private readonly N8Context _context;
        public SQLTicketRepository(N8Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _context.Tickets.Include(x=> x.Sponsor).ToListAsync();
        }

        public Task<Ticket?> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
