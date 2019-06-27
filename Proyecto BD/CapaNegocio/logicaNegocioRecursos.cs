using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioRecursos
    {
        accesoDatosRecursos ac = new accesoDatosRecursos();

        public int insertarRecursos(Recursos re)
        {
            return ac.insertarRecursos(re);
        }

        public List<Recursos> listarRecursos()
        {
            return ac.listarRecursos();
        }

        public int eliminarRecursos(int idrecu)
        {
            return ac.EliminarRecursos(idrecu);
        }


        public int EditarRecursos(Recursos re)
        {
            return ac.EditarRecursos(re);
        }

        public List<Recursos> BuscarRecursos(string dato)
        {
            return ac.BuscarRecursos(dato);
        }

    }
}