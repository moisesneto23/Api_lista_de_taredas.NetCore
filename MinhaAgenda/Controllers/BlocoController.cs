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
    public class BlocoController : ControllerBase
    {
        private BlocoService _blocoService;
        public BlocoController()
        {
            _blocoService = new BlocoService();
        }
        [HttpPost]
        public BlocoTarefas Post(BlocoTarefas bloco)
        {
            return _blocoService.Insert(bloco);
        }
        [HttpPut]
        public BlocoTarefas Put(BlocoTarefas bloco)
        {
            return _blocoService.Update(bloco);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _blocoService.Delete(id);
        }
        [HttpGet("{id}")]
        public BlocoTarefas Get(int id)
        {
            return _blocoService.SelectId(id);
        }
        [HttpGet]
        public List<BlocoTarefas> Get()
        {
            return _blocoService.SelectAll();
        }
    }
}
