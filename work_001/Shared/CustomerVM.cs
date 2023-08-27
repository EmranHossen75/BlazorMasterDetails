using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_001.Shared
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = default!;
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public int Phone { get; set; }
        public string? Picture { get; set; }
        public IFormFile? PictureFile { get; set; }
        public bool MaritalStatus { get; set; }
        public List<Spot> SpotList { get; set; } = new List<Spot>();

        public virtual ICollection<BookingEntry>? BookingEntries { get; set; } = new List<BookingEntry>();
    }
}
