using MedClin.Models;
using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs.MedicoDTOs.Response
{
	public class AtualizarStatusMedicoResponse
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Crm { get; set; }
		public bool Status { get; set; }

        public AtualizarStatusMedicoResponse(Medico medico)
        {
            Id = medico.Id;
			Nome = medico.Nome;
			Crm = medico.Crm;
			Status = medico.Status;
        }

    }
}
