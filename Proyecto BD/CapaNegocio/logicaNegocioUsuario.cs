using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioUsuarios
    {
        accesoDatosUsuarios ac = new accesoDatosUsuarios();

        public int insertarUsuario(Usuarios us)
        {
            return ac.insertarUsuarios(us);
        }

        public List<Usuarios> listarUsuarios()
        {
            return ac.listarUsuarios();
        }

        public int eliminarUsuarios(int idUser)
        {
            return ac.eliminarUsuarios(idUser);
        }


        public int editarUsuarios(Usuarios us)
        {
            return ac.editarUsuarios(us);
        }

        public List<Usuarios> BuscarUsuarios(string dato)
        {
            return ac.BuscarUsuarios(dato);
        }

    }
}