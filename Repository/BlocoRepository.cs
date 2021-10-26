using BancoDados;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class BlocoRepository : IBloco
    {
        private ConectaContext _dbContext;

        public BlocoRepository()
        {
            
             _dbContext = new ConectaContext();
            
        }
        public bool Delete(int id)
        {
            try
            {
                var result = _dbContext.Blocos.SingleOrDefault(p => p.Id.Equals(id));
                if (result == null)
                {
                    return false;
                }
                else
                {
                    var nota = _dbContext.Tarefas.Where(tarefa => tarefa.BlocoId == id).ToList();
                    if (nota == null)
                    {
                        _dbContext.Remove(result);
                        _dbContext.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
                      

        }

       

        public BlocoTarefas Insert(BlocoTarefas bloco)
        {
            try
            {
                var result = _dbContext.Add(bloco);
                 _dbContext.SaveChanges();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<BlocoTarefas> SelectAll()
        {
            try
            {
                return _dbContext.Blocos.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public BlocoTarefas SelectId(int id)
        {
            try
            {
                return _dbContext.Blocos.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public BlocoTarefas Update(BlocoTarefas bloco)
        {
            try
            {
                var result = _dbContext.Update(bloco);
                _dbContext.SaveChanges();
                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
