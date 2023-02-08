using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Services.Services
{
    public class SponsorService
    {
        private readonly ISponsorRepository sponsorRepository;
        public SponsorService(ISponsorRepository sponsorRepository)
        {
            this.sponsorRepository = sponsorRepository;
        }
        public async Task<Sponsor?> GetSponsorByName(string name)
        {
            return await sponsorRepository.GetSponsorByName(name);
        }
        public async Task<IEnumerable<Sponsor?>> GetAllSponsors()
        {
            return await sponsorRepository.GetAllSponsors();
        }
        public async Task<Sponsor?> AddSponsor(Sponsor newSponsor)
        {
            return await sponsorRepository.AddSponsor(newSponsor);
        }
    }
}
