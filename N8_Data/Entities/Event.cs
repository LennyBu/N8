using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    internal class Event:Sponsor
    {
        public string Name { get; set; }
        public List<Sponsor> Sponsors { get; set;}
    }
}
