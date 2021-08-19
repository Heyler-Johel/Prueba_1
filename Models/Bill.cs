using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        public string Alias { get; set; }
        public string AccountNumber { get; set; }
        public float Balance { get; set; }
    }
}
