using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.DTOs.MedicoDTOs.Response;
using MedClin.Models;
using MedClin.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MedicoController : ControllerBase
	{

		private ICadastrarMedicoService _cadastrarMedicoService;
		private IBuscarMedicoPorCrm _encontrarCRM;

		public MedicoController(ICadastrarMedicoService cadastrarMedicoService, IBuscarMedicoPorCrm buscarMedicoPorCrm)
		{
			_cadastrarMedicoService = cadastrarMedicoService;
			_encontrarCRM = buscarMedicoPorCrm;
		}

		[HttpPost]
		public IActionResult CadastrarMedico([FromBody] CadastrarMedicoRequest request)
		{

			var medico = _cadastrarMedicoService.CadastrarMedico(request);

			return CreatedAtAction(nameof(EncontrarMedicoPorCrm), new { crm = medico.Crm }, medico);
		}

		[HttpGet("{crm}")]
		public IActionResult EncontrarMedicoPorCrm(string crm)
		{
			var medico = _encontrarCRM.EncontrarMedicoPorCrm(crm);

			if(medico == null)
			{
				return NotFound($"O médico com o Crm de nr.{medico.Crm}, não foi encontrado.");
			}

			return Ok(new CadastrarMedicoResponse(medico));
		}
	}
}
