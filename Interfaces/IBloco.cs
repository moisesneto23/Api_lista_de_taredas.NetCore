using Entidades;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IBloco
    {
        BlocoTarefas Insert(BlocoTarefas bloco);
        BlocoTarefas Update(BlocoTarefas bloco);
        bool Delete(int id);
        BlocoTarefas SelectId(int id);
        List<BlocoTarefas> SelectAll();
       
    }
}
