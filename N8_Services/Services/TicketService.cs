using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Services.Services
{
    public class TicketService
    {
        private readonly ITicketRepository ticketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        public async Task<Ticket?> GetTicketById(int ticketId)
        {
            return await ticketRepository.GetTicketById(ticketId);
        }
        public async Task<IEnumerable<Ticket?>> GetAllTickets()
        {
            return await ticketRepository.GetAllTickets();
        }
    }
}
