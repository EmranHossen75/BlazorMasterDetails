using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace work_001.Shared
{
    public class Spot
    {
        public int SpotId { get; set; }
        public string? SpotName { get; set; } = default!;

        //nev
        [JsonIgnore]
        public virtual ICollection<BookingEntry>? BookingEntries { get; set; } = new List<BookingEntry>();
    }
}
