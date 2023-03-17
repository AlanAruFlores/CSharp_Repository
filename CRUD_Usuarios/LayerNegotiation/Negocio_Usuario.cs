using LayerModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerNegotiation
{
    public class Negocio_Usuario : INegocio_Usuario
    {
        private UsuarioDAO dao;

        public Negocio_Usuario()
        {
            dao = new UsuarioDAO();
        }
        public void deleteUserInDB(int id)
        {
            dao.deleteUsuario(id);
        }

        public List<Usuario> getAllUsersInDB()
        {
            return dao.getAll();
        }

        public Usuario getUsuarioById(int id)
        {
            return dao.getUsuario(id);
        }

        public void saveUserInDB(Usuario usuario)
        {
            dao.saveUsuario(usuario);
        }

        public void updateUserInDB(Usuario usuario)
        {
            dao.editUsuario(usuario);
        }
    }
}
