using Entidades;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class UsuarioService
    {
        private UsuarioRepository _userRep;
        public UsuarioService()
        {
            _userRep = new();
        }
        public Usuario Inserir(Usuario usuario)
        {
            return _userRep.Inserirt(usuario);
        }
        public Usuario Update(Usuario usuario)
        {
            return _userRep.Update(usuario);
        }
        public bool Delete(int id)
        {
            return _userRep.Delete(id);
        }
        public Usuario SelectId(int id)
        {
            return _userRep.SelectId(id);
        }
        public List<Usuario> SelectAll()
        {
            return _userRep.SelectAll();
        }
    }
}
