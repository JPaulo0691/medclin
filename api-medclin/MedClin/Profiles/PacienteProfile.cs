using AutoMapper;
using MedClin.DTOs;
using MedClin.Models;

namespace MedClin.Profiles
{
    public class PacienteProfile : Profile
	{
        public PacienteProfile()
        {
            CreateMap<CadastrarPacienteDTO, Paciente>();
        }
    }
}
