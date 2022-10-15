using api_servico_motorista.Models;
using api_servico_motorista.Services;
using Microsoft.AspNetCore.Mvc;


namespace api_servico_motorista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristasController : ControllerBase
    {
        private readonly MotoristasService _motoristasService;

        public MotoristasController(MotoristasService motoristasService) =>
            _motoristasService = motoristasService;

        [HttpGet]
        public async Task<List<Motorista>> Get() =>
            await _motoristasService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Motorista>> Get(string id)
        {
            var motorista = await _motoristasService.GetAsync(id);

            if (motorista is null)
            {
                return NotFound();
            }

            return motorista;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Motorista newMotorista)
        {
            await _motoristasService.CreateAsync(newMotorista);

            return CreatedAtAction(nameof(Get), new { id = newMotorista.Id }, newMotorista);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Motorista updatedMotorista)
        {
            var motorista = await _motoristasService.GetAsync(id);

            if (motorista is null)
            {
                return NotFound();
            }

            updatedMotorista.Id = motorista.Id;

            await _motoristasService.UpdateAsync(id, updatedMotorista);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var motorista = await _motoristasService.GetAsync(id);

            if (motorista is null)
            {
                return NotFound();
            }

            await _motoristasService.RemoveAsync(id);

            return NoContent();
        }
    }
}

