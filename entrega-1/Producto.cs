﻿using System;
namespace entrega_1
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto()
        {
        }
    }
}

