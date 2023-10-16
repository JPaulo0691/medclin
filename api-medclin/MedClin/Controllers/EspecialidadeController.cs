using MedClin.DTOs.EspecialidadeDTOs.Request;
using MedClin.Models;
using MedClin.Services.Interface.IEspecialidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class EspecialidadeController : ControllerBase
	{
		private ICadastrarEspecialidadeMedica _cadastrarEspecialidade;
		private IEspecialidadePorId _especialidadePorId;

		public EspecialidadeController(ICadastrarEspecialidadeMedica cadastrarEspecialidade
			                         , IEspecialidadePorId especialidadePorId)
		{
			_cadastrarEspecialidade = cadastrarEspecialidade;
			_especialidadePorId = especialidadePorId;
		}

		[HttpPost]
		public IActionResult CadastrarEspecialidadeMedica([FromBody] CadastrarEspecialidadeRequest request)
		{
			var especialidade =  _cadastrarEspecialidade.Cadastrar(request);

			return CreatedAtAction(nameof(BuscarEspecialidadesMedicasPorId), new { id = especialidade.Id }, especialidade);
		}
		[HttpGet("{id}")] 
		public IActionResult BuscarEspecialidadesMedicasPorId(int id)
		{
			var findEspecialidadesById = _especialidadePorId.EncontrarEspecialidadePorId(id);

			return Ok(findEspecialidadesById);
		}
	}
}
