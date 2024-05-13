using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Logica
{
    public class Logica_Producto
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public string Color { get; set; }   
        public string Tamaño { get; set; }
        public int Stock_Minimo { get; set; }
        public int Stock { get; set; }
        public int Precio_Costo { get; set; }   
        public int Precio_Venta { get; set;}
        public string Nota { get; set; }    

    }
}
