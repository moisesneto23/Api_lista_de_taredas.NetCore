using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Repositorio
{
    public class TarefaService
    {
        private TarefaRepository _tarefaRepository;
        public TarefaService()
        {
            _tarefaRepository = new();
        }
        public List<Tarefa> Inserir(List<Tarefa> tarefa)
        {
            return _tarefaRepository.Inserir(tarefa);
        }
        public  Tarefa Update(Tarefa tarefa)
        {
            return _tarefaRepository.Update(tarefa);
        }
        public  bool Delete(int id)
        {
            return _tarefaRepository.Delete(id);
        }
        public  Tarefa SelectId(int id)
        {
            return _tarefaRepository.SelectId(id);
        }
        public  Tarefa DatatInicio(DateTime dataInicio)
        {
            return _tarefaRepository.selectInicio(dataInicio);
        }
        public  Tarefa DataFinal(DateTime dataTermino)
        {
            return _tarefaRepository.selectFinal(dataTermino);
        }
        public  List<Tarefa> SelectAll()
        {
            return _tarefaRepository.SelectAll();
        }
    }
}
