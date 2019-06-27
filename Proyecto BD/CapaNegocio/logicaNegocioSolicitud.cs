using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioSolicitud
    {
        accesoDatosSolicitud ac = new accesoDatosSolicitud();

        public int insertarSolicitud(Solicitud so)
        {
            return ac.insertarSolicitud(so);
        }

        public List<Solicitud> listarSolicitud()
        {
            return ac.listarSolicitud();
        }

        public int eliminarSolicitud(int idsolic)
        {
            return ac.eliminarSolicitud(idsolic);
        }


        public int EditarSolicitud(Solicitud so)
        {
            return ac.EditarSolicitud(so);
        }

        public List<Solicitud> BuscarSolicitud(string dato)
        {
            return ac.BuscarSolicitud(dato);
        }

    }
}