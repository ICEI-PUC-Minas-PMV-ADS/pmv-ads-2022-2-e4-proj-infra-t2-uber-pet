using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_servico_usuario.Models;
using NuGet.Protocol.Plugins;

namespace api_servico_usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios
                .Include(t => t.Passageiro)
                .Include(p => p.Passageiro.Pets)
                .FirstOrDefaultAsync(c => c.IdUsuario == id);

            if (usuario == null)
            {
                return NotFound();
            }

            GerarLinks(usuario);
            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UsuarioDto usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return BadRequest();
            }

            var modeloDb = await _context.Usuarios.AsNoTracking()
                .FirstOrDefaultAsync(c => c.IdUsuario == id);

            if (modeloDb == null)
            {
                return NotFound();
            }

            modeloDb.Nome = usuario.Nome;
            modeloDb.Login = usuario.Login;
            modeloDb.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            modeloDb.Ativo = usuario.Ativo;
            modeloDb.Perfil = usuario.Perfil;
            modeloDb.Passageiro = usuario.Passageiro;

            _context.Usuarios.Update(modeloDb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioDto>> PostUsuario(UsuarioDto usuario)
        {
            Usuario novo = new Usuario()
            {
                Nome = usuario.Nome,
                Login = usuario.Login,
                Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha),
                Ativo = usuario.Ativo,
                Perfil = usuario.Perfil,
                Passageiro = usuario.Passageiro
            };

            _context.Usuarios.Add(novo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = novo.IdUsuario }, novo);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }

        private void GerarLinks(Usuario usuario)
        {
            usuario.Links.Add(new LinkDto(usuario.IdUsuario, Url.ActionLink(), rel: "self", metodo: "GET"));
            usuario.Links.Add(new LinkDto(usuario.IdUsuario, Url.ActionLink(), rel: "self", metodo: "PUT"));
            usuario.Links.Add(new LinkDto(usuario.IdUsuario, Url.ActionLink(), rel: "self", metodo: "Delete"));
        }
    }
}
