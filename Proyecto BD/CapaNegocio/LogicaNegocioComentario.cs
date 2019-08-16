using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioComentario
    {
        accesoDatosComentarios ac = new accesoDatosComentarios();

        public int insertarComentarios(Comentarios CO)
        {
            return ac.insertarComentarios(CO);
        }

        public List<Comentarios> listarComentarios()
        {
            return ac.listarComentarios();
        }

        public int eliminarComentarios(int idComent) 
        {
            return ac.eliminarComentarios(idComent);
        }


        public int EditarComentario(Comentarios CO)
        {
            return ac.EditarComentarios(CO);
        }

        public List<Comentarios> BuscarComentario(string dato)
        {
            return ac.BuscarComentarios(dato);
        }


       /* public int insertarComentarios(global::CapaPresentacionWeb.Comentarios CE)
        {
            throw new NotImplementedException();
        }*/
    }
}
