using AutoMapper;
using MedClin.DataBase;
using MedClin.DTOs;
using MedClin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class PacienteController : ControllerBase
	{
		private PacienteContext _context;
		private IMapper _mapper;

		public PacienteController(PacienteContext context)
		{
			_context = context;			
		}

		[HttpPost]
		public IActionResult CadastrarPaciente([FromBody] CadastrarPacienteDTO pacienteDTO)
		{
			Paciente paciente = new Paciente(pacienteDTO);

			_context.Paciente.Add(paciente);
			_context.SaveChanges();
            
			return CreatedAtAction(nameof(PacienteEspecificoId),new { id = paciente.Id}, paciente);

        }

		[HttpGet]
		public IEnumerable<Paciente> ListarTodosPacientes([FromQuery] int skip = 0, int take = 10)
		{
			return _context.Paciente.Skip(skip).Take(take); // paginação skip = qtos elementos pular | take = qtos elementos pegar
		}

		[HttpGet("pacientesAtivos")]
		public IEnumerable<Paciente> ListarTodosPacientesAtivos([FromQuery]int skip = 0, int take = 10)
		{
			return _context.Paciente.Skip(skip).Take(take).Where(pacientes => pacientes.Status == true); // paginação skip = qtos elementos pular | take = qtos elementos pegar
		}

		[HttpGet("pacientesInativos")]
		public IEnumerable<Paciente> ListarTodosPacientesInativos([FromQuery] int skip = 0, int take = 10)
		{
			return _context.Paciente.Skip(skip).Take(take).Where(pacientes => pacientes.Status == false); // paginação skip = qtos elementos pular | take = qtos elementos pegar
		}

		[HttpGet("{id}")]
		public IActionResult PacienteEspecificoId(int id)
		{
			var paciente = _context.Paciente.FirstOrDefault(paciente => paciente.Id == id);
			if (paciente == null) 
				return NotFound();

			return Ok(paciente);
		}

		[HttpPut("{id}")]
		public IActionResult AtualizarCadastro(int id,[FromBody] AtualizarPacienteDTO atualizarPaciente)
		{
			var paciente = _context.Paciente.FirstOrDefault(pacient => pacient.Id == id);

			if(paciente == null) return NotFound();

			paciente.Nome = atualizarPaciente.Nome;
			paciente.Cpf = atualizarPaciente.Cpf;
			paciente.Endereco = new Endereco(atualizarPaciente);
			paciente.Contato = atualizarPaciente.Contato;
			
			_context.SaveChanges();

			return Ok(paciente);
		}

		[HttpPut("{id}/alterarstatus")]
		public ActionResult AlterarStatus(int id, [FromBody] AtualizarStatusDTO atualizarStatus) 
		{
			var pacienteStatus = _context.Paciente.FirstOrDefault(paciente => paciente.Id == id);

			if (pacienteStatus == null) return NotFound("Paciente Não Encontrado");

			pacienteStatus.Status = atualizarStatus.Status;
			_context.SaveChanges();

			StatusResponse pacienteResponse = new StatusResponse(pacienteStatus);

			return Ok(pacienteResponse);
		}

		[HttpDelete("{id}")]
		public ActionResult deletarCadastroPaciente(int id)
		{
			var paciente = _context.Paciente.FirstOrDefault(delPaciente => delPaciente.Id == id);

			if (paciente == null) return NotFound("Paciente Não Encontrado");

			_context.Remove(paciente);
			_context.SaveChanges();

			return NoContent();
		}
	}
}
