using PruebadePractica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Core.Interface
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetPersonas();
        Task<Persona> GetPersona(int id);
        Task InsertPersona(Persona newPersona);
        Task<bool> UpdatePersona(Persona persona);
        Task<bool> DeletePersona(int id);
    }
}
