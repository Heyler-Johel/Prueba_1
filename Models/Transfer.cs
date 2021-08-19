using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Transfer
    {
        [Key]
        public int TransferId { get; set; }
        public int ClientId { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public Bill BillStart { get; set; }
        public Bill BillEnd { get; set; }
        
        
    }
}
