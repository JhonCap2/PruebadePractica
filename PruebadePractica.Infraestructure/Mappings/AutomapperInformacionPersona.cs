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
    public class AutomapperInformacionPersona : Profile
    {
        public AutomapperInformacionPersona()
        {
            CreateMap<InformacionPersona, InformacionPersonaDto>();
            CreateMap<InformacionPersonaDto, InformacionPersona>();
        }
    }
}
