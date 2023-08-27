using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_001.Shared
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = default!;
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public string? Picture { get; set; } = null!;
        public bool MaritalStatus { get; set; }

        //nev
        public virtual ICollection<BookingEntry>? BookingEntries { get; set; } = new List<BookingEntry>();
    }
}
