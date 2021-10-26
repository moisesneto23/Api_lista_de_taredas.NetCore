using Entidades;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IUsuario
    {
        Usuario Inserirt(Usuario usuario);
        Usuario Update(Usuario usuario);
        bool Delete(int id);
        Usuario SelectId(int id);
        List<Usuario> SelectAll();
        
    }
}
