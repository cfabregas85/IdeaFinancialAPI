using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIdeaFinancial.Models
{
    public class ModelClass
    {
        public string Id { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }
        public decimal availablefunds { get; set; }
        public decimal creditlimit { get; set; }
    }
}
