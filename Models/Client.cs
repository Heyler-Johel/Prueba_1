using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationCard { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public string Address { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
