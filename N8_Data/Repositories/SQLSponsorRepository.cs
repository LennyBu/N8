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
    public class SQLSponsorRepository : ISponsorRepository
    {
        private readonly N8Context _context;
        public SQLSponsorRepository(N8Context context)
        {
            _context = context;
        }

        public async Task<Sponsor?> AddSponsor(Sponsor newSponsor)
        {
            _context.Sponsors.Add(newSponsor);
            await _context.SaveChangesAsync();
            return newSponsor;
        }

        public async Task<IEnumerable<Sponsor>> GetAllSponsors()
        {
            return await _context.Sponsors.Where(x=> x.Name != null)
                .Include(x => x.Tickets).ToListAsync();
        }

        public async Task<Sponsor?> GetSponsorByName(string name)
        {
            return await _context.Sponsors.Where(x=> x.Name == name)
                .Include(x => x.Tickets).FirstAsync();
        }
    }
}
