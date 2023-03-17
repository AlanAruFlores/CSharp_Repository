using System;
using System.Collections.Generic;
using System.Text;
using LayerModel;
namespace LayerNegotiation
{
    public interface INegocio_Usuario
    {

        List<Usuario> getAllUsersInDB();
        Usuario getUsuarioById(int id);
        void saveUserInDB(Usuario usuario);
        void updateUserInDB(Usuario usuario);
        void deleteUserInDB(int id);


    
    }
}
