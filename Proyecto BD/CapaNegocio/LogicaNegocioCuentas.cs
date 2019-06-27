using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioCuentas
    {
        accesoDatosCuentas ac = new accesoDatosCuentas();

        public int insertarCuentas(Cuentas Cu)
        {
            return ac.insertarCuentas(Cu);
        }

        public List<Cuentas> listarCuentas()
        {
            return ac.listarCuentas();
        }

        public int eliminarCuentas(int idCuent)
        {
            return ac.eliminarCuentas(idCuent);
        }


        public int EditarCuentas(Cuentas Cu)
        {
            return ac.EditarCuentas(Cu);
        }

        public List<Cuentas> BuscarCuentas(string dato)
        {
            return ac.BuscarCuentas(dato);
        }

    }
}