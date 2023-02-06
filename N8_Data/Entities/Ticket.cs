using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Timetable { get; set; }
    }
}
