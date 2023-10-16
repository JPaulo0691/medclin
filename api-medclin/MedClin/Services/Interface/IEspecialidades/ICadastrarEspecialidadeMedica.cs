using MedClin.DTOs.EspecialidadeDTOs.Request;
using MedClin.Models;

namespace MedClin.Services.Interface.IEspecialidades
{
	public interface ICadastrarEspecialidadeMedica
	{
		Especialidades Cadastrar(CadastrarEspecialidadeRequest especialidade);
	}
}
