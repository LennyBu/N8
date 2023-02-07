using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    [Table("Tickets")]
    public class Ticket
    {
        public int Id { get; set; }
        public virtual Sponsor Sponsor { get; set; }
        public string Type { get; set; }
    }
}
