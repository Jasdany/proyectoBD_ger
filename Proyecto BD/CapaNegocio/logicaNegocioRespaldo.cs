﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    class logicaNegocioRespaldo
    {
        accesoDatosRespaldoBD rbd = new accesoDatosRespaldoBD();

        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }

}
