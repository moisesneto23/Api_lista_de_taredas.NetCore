using BancoDados;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class TarefaRepository : ITarefas
    {
        private ConectaContext _dbContext;
        public TarefaRepository()
        {
            _dbContext = new ConectaContext();
        }
        public bool Delete(int id)
        {
            try
            {
                var result = _dbContext.Tarefas.FirstOrDefault(c => c.Id == id);
                if (result == null)
                {
                    return false;
                }
                else
                {
                    _dbContext.Remove(result);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

       

        public List<Tarefa> Inserir(List<Tarefa> tarefas)
        {
            try
            {
                var result = _dbContext.Add(tarefas);
                _dbContext.SaveChanges();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Tarefa> SelectAll()
        {
            try
            {
                return _dbContext.Tarefas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Tarefa selectFinal(DateTime dataTermino)
        {
            try
            {
                return _dbContext.Tarefas.FirstOrDefault(
                    c => c.DataFinal == dataTermino);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Tarefa SelectId(int id)
        {
            try
            {
                return _dbContext.Tarefas.FirstOrDefault(
                    c => c.Id == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Tarefa selectInicio(DateTime dataInicio)
        {
            try
            {
                return _dbContext.Tarefas.FirstOrDefault(
                    c => c.DataInicio == dataInicio);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Tarefa Update(Tarefa tarefa)
        {
            try
            {
                var result = _dbContext.Update(tarefa);
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
