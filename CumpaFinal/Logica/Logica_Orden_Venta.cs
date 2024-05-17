using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Logica
{
    public class Logica_Orden_Venta
    {
        public int ID_Orden_Venta { get; set; }  
        public string Producto { get; set; }
        public string Combo { get; set; }
        public string Cliente { get; set; }
        public string ModoPago { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Total { get; set; }  
        public string EstadoPedido { get; set; }
        public string Nota { get; set; }    

    }
}
