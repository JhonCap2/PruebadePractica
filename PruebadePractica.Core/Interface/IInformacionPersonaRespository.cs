using PruebadePractica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Core.Interface
{
    public interface IInformacionPersonaRespository
    {
        Task<IEnumerable<InformacionPersona>> GetInformacionPersonas();
        Task<InformacionPersona> GetPersona(int id);
        Task InsertInformacionPersona(InformacionPersona informacionPersona);
        Task<bool> UpdateInformacionPersona(InformacionPersona informacionPersona);
        Task<bool> DeleteInformacionPersona(int id);
    }
}
