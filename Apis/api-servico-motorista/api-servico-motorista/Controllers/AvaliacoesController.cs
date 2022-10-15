using api_servico_motorista.Models;
using api_servico_motorista.Services;
using Microsoft.AspNetCore.Mvc;


namespace api_servico_motorista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacoesController : ControllerBase
    {
        private readonly AvaliacoesService _avaliacoesService;

        public AvaliacoesController(AvaliacoesService avaliacoesService) =>
            _avaliacoesService = avaliacoesService;

        [HttpGet]
        public async Task<List<Avaliacao>> Get() =>
            await _avaliacoesService.GetAsync();

        [HttpGet("{id:length(12)}")]
        public async Task<ActionResult<Avaliacao>> Get(string id)
        {
            var avaliacao = await _avaliacoesService.GetAsync(id);

            if (avaliacao is null)
            {
                return NotFound();
            }

            return avaliacao;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Avaliacao newAvaliacao)
        {
            await _avaliacoesService.CreateAsync(newAvaliacao);

            return CreatedAtAction(nameof(Get), new { id = newAvaliacao.Id }, newAvaliacao);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Avaliacao updatedAvaliacao)
        {
            var avaliacao = await _avaliacoesService.GetAsync(id);

            if (avaliacao is null)
            {
                return NotFound();
            }

            updatedAvaliacao.Id = avaliacao.Id;

            await _avaliacoesService.UpdateAsync(id, updatedAvaliacao);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var avaliacao = await _avaliacoesService.GetAsync(id);

            if (avaliacao is null)
            {
                return NotFound();
            }

            await _avaliacoesService.RemoveAsync(id);

            return NoContent();
        }
    }
}

