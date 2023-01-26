using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Core.Entities
{
    public partial class Persona
    {
        public Persona()
        {
                InformacionPersonas = new HashSet<InformacionPersona>();
        }
        public int IdPerson { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Identification { get; set; }
        
        public virtual ICollection<InformacionPersona> InformacionPersonas { get; set; }

    }
}
