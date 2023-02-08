using N8_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public interface ISponsorRepository
    {
        Task<Sponsor?> GetSponsorByName(string name);
        Task<IEnumerable<Sponsor>> GetAllSponsors();
        Task<Sponsor?> AddSponsor(Sponsor newSponsor);
    }
}
