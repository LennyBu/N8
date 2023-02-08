using N8_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket?> GetTicketById(int id);
        Task<IEnumerable<Ticket>> GetAllTickets();
    }
}
