﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Productos
{
    public class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Stock { get; set; }
        public long IdUsuario { get; set; }
    }
}
