using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;
using MedClin.Services.Interface;
using MedClin.Validations;

namespace MedClin.Services.ServicesImpl
{
	public class MedicoService : ICadastrarMedicoService, IBuscarMedicoPorCrm
	{
		private MedicoContext _context;
		private IEnumerable<IValidForm<CadastrarMedicoRequest>> _validator;

		public MedicoService(MedicoContext context, IEnumerable<IValidForm<CadastrarMedicoRequest>> validator )
		{
			_context = context;
			_validator = validator;
		}

		public Medico CadastrarMedico(CadastrarMedicoRequest request)
		{
			_validator.ToList().ForEach(valid => valid.validForm(request));

			Medico medico = new Medico(request);

			_context.Medico.Add(medico);
			_context.SaveChanges();

			return medico;
		}

		public Medico EncontrarMedicoPorCrm(string crm)
		{
			Medico medico = _context.Medico.FirstOrDefault(medico => medico.Crm.Equals(crm));

			if (medico == null)
			{
				throw new Exception($"O médico de CRM {medico.Crm} não foi encontrado");
			}

			return medico;
		}
	}
}
