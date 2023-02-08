using Microsoft.EntityFrameworkCore;
using N8_Data.Entities;
using N8_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public class SQLLoginRepository : ILoginRepository
    {
        private readonly N8Context _context;
        public SQLLoginRepository(N8Context context)
        {
            _context = context;
        }
        public async Task<Login?> GetLogin(string username)
        {
            return await _context.Logins.Where(x => x.Name == username).FirstAsync();
        }
    }
}
