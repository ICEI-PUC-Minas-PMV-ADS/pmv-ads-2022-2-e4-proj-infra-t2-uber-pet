using api_servico_motorista.Models;
using api_servico_motorista.Services;
using Microsoft.AspNetCore.Mvc;


namespace api_servico_motorista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly VeiculosService _veiculosService;

        public VeiculosController(VeiculosService veiculosService) =>
            _veiculosService = veiculosService;

        [HttpGet]
        public async Task<List<Veiculo>> Get() =>
            await _veiculosService.GetAsync();

        [HttpGet("{id:length(12)}")]
        public async Task<ActionResult<Veiculo>> Get(string id)
        {
            var veiculo = await _veiculosService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            return veiculo;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Veiculo newVeiculo)
        {
            await _veiculosService.CreateAsync(newVeiculo);

            return CreatedAtAction(nameof(Get), new { id = newVeiculo.Id }, newVeiculo);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Veiculo updatedVeiculo)
        {
            var veiculo = await _veiculosService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            updatedVeiculo.Id = veiculo.Id;

            await _veiculosService.UpdateAsync(id, updatedVeiculo);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var veiculo = await _veiculosService.GetAsync(id);

            if (veiculo is null)
            {
                return NotFound();
            }

            await _veiculosService.RemoveAsync(id);

            return NoContent();
        }
    }
}

