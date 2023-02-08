using N8_Data.Repositories;
using N8_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Services.Services
{
    public  class LoginService
    {
        private readonly ILoginRepository loginRepository;
        public LoginService(ILoginRepository loginrepository)
        {
            this.loginRepository = loginrepository;
        }
        public async Task<Login?> GetLogin(string username)
        {
            return await loginRepository.GetLogin(username);
        }
    }
}
