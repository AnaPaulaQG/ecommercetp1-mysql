using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommercetp1
{
    public class Envio
    {
        public int ID_Envio { get; set; }
        public int ID_Venta { get; set; }
        public string Direccion { get; set; }
        public string Empresa { get; set; }
        public string EstadoEnvio { get; set; }
    }
}
