using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;
using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs.MedicoDTOs.Response
{
	public class CadastrarMedicoResponse
	{
		public int Id { get; set; }		
		public string Nome { get; set; }		
		public string Crm { get; set; }
		public string Status { get; set; }

		public string Especialidade { get; set; }

		public CadastrarMedicoResponse() { }

        public CadastrarMedicoResponse(Medico cadastrarMedico)
        {
			Id = cadastrarMedico.Id;
			Nome = cadastrarMedico.Nome;
			Crm = cadastrarMedico.Crm;
			Status = (cadastrarMedico.Status) ? "Ativo" : "Inativo";
			Especialidade = cadastrarMedico.Especialidade.Nome;
		}

		
	}
}
