using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Hotels
    {
        [Key]
        public int Hid { get; set; }
        public string? HName { get; set; }

        public string? Location { get; set; }
        public int   Rating {get;set;}

        public int TotalRooms { get; set; }

        public int Feedback { get; set; }

    }
}
