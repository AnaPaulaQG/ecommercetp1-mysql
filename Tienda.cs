using System;
using System.Collections.Generic;
using System.Text;

namespace ecommercetp1
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public int IdUsuarioAdm { get; set; }
        public string? Nombre { get; set; }
        public string? Url { get; set; }
        public bool Estado { get; set; }
    }
}