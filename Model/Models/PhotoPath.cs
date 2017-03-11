using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Models
{
    public class PhotoPath
    {
        public int PhotoPathId { get; set; }
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
        public string Path { get; set; }
        public bool IsMain { get; set; }
    }
}
