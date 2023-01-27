using Microsoft.EntityFrameworkCore;
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
    public class PersonaRepository : IPersonaRepository
    {
        private readonly PersonaContext _context;

        public PersonaRepository(PersonaContext context)
        {
            _context = context;
        }
        public async Task<bool> DeletePersona(int id)
        {
            var personaD = await GetPersona(id);
            _context.Personas.Remove(personaD);
            int DeletePersona = await _context.SaveChangesAsync();
            return DeletePersona > 0;
        }

        public async Task<Persona> GetPersona(int id)
        {
            var persona = await _context.Personas.SingleOrDefaultAsync(x =>x.IdPerson == id);
            return persona;
        }

        public async Task<IEnumerable<Persona>> GetPersonas()
        {
            var personas = await _context.Personas.ToListAsync();
            return personas;
        }

        public async Task InsertPersona(Persona newPersona)
        {
            await _context.Personas.AddAsync(newPersona);
            _context.SaveChanges();
        }

        public async Task<bool> UpdatePersona(Persona persona)
        {
            var personaU = await GetPersona(persona.IdPerson);
            personaU.IdPerson = persona.IdPerson;
            personaU.Names = persona.Names;
            personaU.LastName = persona.LastName;
            personaU.Identification = persona.Identification;
            personaU.DateOfBirth = persona.DateOfBirth;

            int UpdatePersona = await _context.SaveChangesAsync();

            return UpdatePersona > 0;
        }
    }
}
