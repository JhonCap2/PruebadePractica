using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PruebadePractica.Core.Entities
{
    public partial class InformacionPersona
    {
        public int IdInformacionPersona { get; set; }
        public int IdPerson { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Work { get; set; }

        [JsonIgnore]
        public virtual Persona? Persona { get; set; }
    }
}
