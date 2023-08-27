using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_001.Shared
{
    public class BookingEntry
    {
        public int BookingEntryId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Spot")]
        public int SpotId { get; set; }

        //nev
        public virtual Customer? Customer { get; set; }
        public virtual Spot? Spot { get; set; }
    }
}
