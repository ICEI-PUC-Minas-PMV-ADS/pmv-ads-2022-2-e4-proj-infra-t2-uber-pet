using api_servico_motorista.Models;
using api_servico_motorista.Services;
using Microsoft.AspNetCore.Mvc;


namespace api_servico_motorista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagensController : ControllerBase
    {
        private readonly ViagensService _viagensService;

        public ViagensController(ViagensService viagensService) =>
            _viagensService = viagensService;

        [HttpGet]
        public async Task<List<Viagem>> Get() =>
            await _viagensService.GetAsync();

        [HttpGet("{id:length(12)}")]
        public async Task<ActionResult<Viagem>> Get(string id)
        {
            var viagem = await _viagensService.GetAsync(id);

            if (viagem is null)
            {
                return NotFound();
            }

            return viagem;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Viagem newViagem)
        {
            await _viagensService.CreateAsync(newViagem);

            return CreatedAtAction(nameof(Get), new { id = newViagem.Id }, newViagem);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Viagem updatedViagem)
        {
            var viagem = await _viagensService.GetAsync(id);

            if (viagem is null)
            {
                return NotFound();
            }

            updatedViagem.Id = viagem.Id;

            await _viagensService.UpdateAsync(id, updatedViagem);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var viagem = await _viagensService.GetAsync(id);

            if (viagem is null)
            {
                return NotFound();
            }

            await _viagensService.RemoveAsync(id);

            return NoContent();
        }
    }
}

