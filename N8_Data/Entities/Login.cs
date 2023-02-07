using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    [Table("Logins")]
    public class Login
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
