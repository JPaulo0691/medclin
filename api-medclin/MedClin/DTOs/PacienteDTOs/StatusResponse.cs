using MedClin.Models;

namespace MedClin.DTOs
{
	public class StatusResponse
	{
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public bool Status { get; set; }

		public StatusResponse() { }

		public StatusResponse(Paciente paciente)
		{
			Nome = paciente.Nome;
			Cpf = paciente.Cpf;
			Status = paciente.Status;
		}

	}
}
