using MedClin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Services.Interface
{
	public interface IListarTodosOsMedicosDisponiveis
	{
		IEnumerable<Medico> ListarTodosOsMedicosDisponiveis([FromQuery] int skip = 0, int take = 10);
	}
}
