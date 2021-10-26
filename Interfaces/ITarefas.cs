using Entidades;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITarefas
    {
        List<Tarefa> Inserir(List<Tarefa> tarefa);
        Tarefa Update(Tarefa tarefa);
        bool Delete(int id);
        Tarefa SelectId(int id);
        Tarefa selectInicio(DateTime dataInicio);
        Tarefa selectFinal(DateTime dataTermino);
        List<Tarefa> SelectAll();
    }
}
