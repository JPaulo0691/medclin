using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;

namespace MedClin.Services.Interface
{
	public interface ICadastrarMedicoService
	{
		Medico CadastrarMedico(CadastrarMedicoRequest request);
	}
}
