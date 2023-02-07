using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    [Table("Events")]
    [Keyless]
    public class Event
    {
        public string Name { get; set; }
        [Column("Sponsors")]
        public virtual ICollection<Sponsor> Sponsors { get; set;}
    }
}
