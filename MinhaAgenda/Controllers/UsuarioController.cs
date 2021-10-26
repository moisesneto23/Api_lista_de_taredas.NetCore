using Entidades;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAgenda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController: ControllerBase
    {
        private UsuarioService _usuarioService;
        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }
        [HttpPost]
        public Usuario Post(Usuario Usuario)
        {
            return _usuarioService.Inserir(Usuario);
        }
        [HttpPut]
        public Usuario Put(Usuario Usuario)
        {
            return _usuarioService.Update(Usuario);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _usuarioService.Delete(id);
        }
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _usuarioService.SelectId(id);
        }
        [HttpGet]
        public List<Usuario> Get()
        {
            return _usuarioService.SelectAll();
        }
    }
}
