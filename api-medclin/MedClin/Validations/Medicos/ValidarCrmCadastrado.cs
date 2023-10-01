using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;

namespace MedClin.Validations.Medicos
{
	public class ValidarCrmCadastrado : IValidForm<CadastrarMedicoRequest>
	{
		private MedicoContext _medicoContext;

		public ValidarCrmCadastrado(MedicoContext medicoContext)
		{
			_medicoContext = medicoContext;
		}

		public void validForm(CadastrarMedicoRequest cadastro)
		{
			var crm = _medicoContext.Medico.Any(medico => medico.Crm.Equals(cadastro.Crm));

			if(crm == true)
			{
				throw new Exception($"O médico com o Crm de nr.{cadastro.Crm}, já foi cadastrado");
			}

		}
	}
}
