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
		public bool Status { get; set; }

		public CadastrarMedicoResponse() { }

        public CadastrarMedicoResponse(Medico cadastrarMedico)
        {
			Id = cadastrarMedico.Id;
            Nome = cadastrarMedico.Nome;
			Crm = cadastrarMedico.Crm;
			Status = cadastrarMedico.Status;
        }
    }
}
