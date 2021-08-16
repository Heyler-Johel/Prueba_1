using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationCard { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    }
}
