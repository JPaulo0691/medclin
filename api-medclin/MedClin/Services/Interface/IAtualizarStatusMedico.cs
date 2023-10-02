using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;

namespace MedClin.Services.Interface
{
	public interface IAtualizarStatusMedico
	{
		Medico alterarStatus(string crm, AtualizarStatusMedicoRequest atualizarStatus);
	}
}
