using Entidades;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class BlocoService 
    {
        private BlocoRepository _blocoRepository;

        public BlocoService()
        {
            _blocoRepository = new BlocoRepository();
        }

        public BlocoTarefas Insert(BlocoTarefas bloco)
        {
            return _blocoRepository.Insert(bloco);
        }
        public BlocoTarefas Update(BlocoTarefas bloco)
        {
            return _blocoRepository.Update(bloco);
        }
        public bool Delete(int id)
        {
            return _blocoRepository.Delete(id);
        }
        public BlocoTarefas SelectId(int id)
        {
            return _blocoRepository.SelectId(id);
        }
        public List<BlocoTarefas> SelectAll()
        {
            return _blocoRepository.SelectAll();
        }
    }
}
