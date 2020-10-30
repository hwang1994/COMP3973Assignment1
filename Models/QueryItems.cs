using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class QueryItems
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public IEnumerable<Item> items { get; set; }
    }
}
