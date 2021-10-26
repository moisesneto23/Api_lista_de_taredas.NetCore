using BancoDados;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsuarioRepository : IUsuario
    {
        private ConectaContext _dbContext;
        public UsuarioRepository()
        {
            _dbContext = new ConectaContext();
        }
        public bool Delete(int id)
        {
            try
            {
                var result = _dbContext.Usuarios.FirstOrDefault(c => c.Id == id);
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

        public Usuario Inserirt(Usuario usuario)
        {
            try
            {
                var result = _dbContext.Add(usuario);
                _dbContext.SaveChanges();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Usuario> SelectAll()
        {
            try
            {
                return _dbContext.Usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario SelectId(int id)
        {
            try
            {
                return _dbContext.Usuarios.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Usuario Update(Usuario usuario)
        {
            try
            {
                var result = _dbContext.Update(usuario);
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
