using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Core.DTOs
{
    public class InformacionPersonaDto
    {
        public int IdInformacionPersona { get; set; }
        public int IdPerson { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Work { get; set; }
    }
}
