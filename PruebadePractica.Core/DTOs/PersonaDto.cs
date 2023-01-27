using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Core.DTOs
{
    public class PersonaDto
    {
        public int IdPerson { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Identification { get; set; }
    }
}
