using AutoMapper;
using PruebadePractica.Core.DTOs;
using PruebadePractica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Infraestructure.Mappings
{
    public class AutomapperPersona : Profile
    {
        public AutomapperPersona()
        {
            CreateMap<Persona, PersonaDto>();
            CreateMap<PersonaDto, Persona>();
        }
    }
}
