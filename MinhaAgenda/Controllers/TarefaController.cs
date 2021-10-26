using Entidades;
using Microsoft.AspNetCore.Mvc;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAgenda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefaController : ControllerBase
    {
        private TarefaService _tarefaService;
        public TarefaController()
        {
            _tarefaService = new();
        }
        [HttpGet]
        public List<Tarefa> Get()
        {
            return _tarefaService.SelectAll();
        }
        [HttpGet("{id}")]
        public Tarefa Get(int id)
        {
            return _tarefaService.SelectId(id);
        }
        [HttpGet("{inicio}")]
        public Tarefa GetInicio(DateTime inicio)
        {
            return _tarefaService.DatatInicio(inicio);
        }
        [HttpGet("{final}")]
        public Tarefa GetFinal(DateTime final)
        {
            return _tarefaService.DataFinal(final);
        }
        [HttpPost]
        public List<Tarefa> Post(List<Tarefa> tarefas)
        {
            return _tarefaService.Inserir(tarefas);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _tarefaService.Delete(id);
        }
        [HttpPut]
        public Tarefa Put(Tarefa tarefa)
        {
            return _tarefaService.Update(tarefa);
        }
    }
}
