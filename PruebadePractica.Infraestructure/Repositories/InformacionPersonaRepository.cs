using PruebadePractica.Core.Entities;
using PruebadePractica.Core.Interface;
using PruebadePractica.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Infraestructure.Repositories
{
    public class InformacionPersonaRepository :IInformacionPersonaRespository
    {
        private readonly PersonaContext _context;

        public InformacionPersonaRepository(PersonaContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<InformacionPersona>> GetInformacionPersonas()
        {
            throw new NotImplementedException();
        }

        public Task<InformacionPersona> GetPersona(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertInformacionPersona(InformacionPersona informacionPersona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateInformacionPersona(InformacionPersona informacionPersona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteInformacionPersona(int id)
        {
            throw new NotImplementedException();
        }
    }
}
