using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;

namespace MedClin.Validations.Medicos
{
	public class ValidarCrmCadastrado : IValidForm<CadastrarMedicoRequest>
	{
		private MedicoRepository _medicoContext;

		public ValidarCrmCadastrado(MedicoRepository medicoContext)
		{
			_medicoContext = medicoContext;
		}

		public void validForm(CadastrarMedicoRequest cadastro)
		{
			var crm = _medicoContext.Medicos.Any(medico => medico.Crm.Equals(cadastro.Crm));

			if(crm == true)
			{
				throw new Exception($"O médico com o Crm de nr.{cadastro.Crm}, já foi cadastrado");
			}

		}
	}
}
