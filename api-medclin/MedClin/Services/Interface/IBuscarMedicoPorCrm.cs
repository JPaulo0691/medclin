using MedClin.Models;

namespace MedClin.Services.Interface
{
	public interface IBuscarMedicoPorCrm
	{
		Medico EncontrarMedicoPorCrm(string crm);
	}
}
