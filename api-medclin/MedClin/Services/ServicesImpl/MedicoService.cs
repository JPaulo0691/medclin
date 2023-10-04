using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;
using MedClin.Services.Interface;
using MedClin.Validations;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Services.ServicesImpl
{
	public class MedicoService : ICadastrarMedicoService, IBuscarMedicoPorCrm, IListarTodosOsMedicosDisponiveis, IAtualizarStatusMedico
	{
		private MedicoRepository _context;
		private IEnumerable<IValidForm<CadastrarMedicoRequest>> _validator;

		public MedicoService(MedicoRepository context, IEnumerable<IValidForm<CadastrarMedicoRequest>> validator )
		{
			_context = context;
			_validator = validator;
		}

		public Medico CadastrarMedico(CadastrarMedicoRequest request)
		{
			_validator.ToList().ForEach(valid => valid.validForm(request));

			Medico medico = new Medico(request);

			_context.Medicos.Add(medico);
			_context.SaveChanges();

			return medico;
		}

		public IEnumerable<Medico> ListarTodosOsMedicosDisponiveis([FromQuery] int skip = 0, int take = 10)
		{
			return _context.Medicos.Skip(skip).Take(take).Where(medico => medico.Status == true);
		}

		public Medico EncontrarMedicoPorCrm(string crm)
		{
			Medico medico = _context.Medicos.FirstOrDefault(medico => medico.Crm.Equals(crm));

			if (medico == null)
			{
				throw new Exception($"O médico de CRM {medico.Crm} não foi encontrado");
			}

			return medico;
		}

		public Medico alterarStatus(string crm, AtualizarStatusMedicoRequest atualizarStatus)
		{
			Medico medico = _context.Medicos.FirstOrDefault(medico => medico.Crm.Equals(crm));

			if (medico == null)
			{
				throw new Exception($"O médico de CRM {medico.Crm} não foi encontrado");
			}
			else
			{
				medico.Status = atualizarStatus.Status;
				_context.SaveChanges();
			}

			return medico;

		}
	}
}
