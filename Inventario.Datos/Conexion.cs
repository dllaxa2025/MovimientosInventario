﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Datos
{
    public class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["Inv"].ToString();
    }
}
