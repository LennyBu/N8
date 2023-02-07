using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Entities
{
    [Table("Sponsors")]
    public class Sponsor
    {
        public string Name { get; set; }
        [Column("Tickets")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        
    }
}
