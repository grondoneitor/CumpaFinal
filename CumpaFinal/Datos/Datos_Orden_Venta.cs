using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{
    internal class Datos_Orden_Venta
    {
        Conexion conn;
         public Datos_Orden_Venta()
        {
            conn = new Conexion();
        }


        public DataSet MostrarOrden()
        {
            SqlCommand mostrar = new SqlCommand($"select ov.ID_Orden_Venta, pp.Producto, cc.Combo,cl.Nombre,mp.Modo_Pago,ov.Cantidad,ov.Fecha_Venta,ov.Total, ov.Estado_Pedido,ov.Nota\r\nfrom Orden_Venta ov \r\nleft join Productos pp on ov.ID_Producto = pp.ID_Productos\r\nleft join Combos cc on ov.ID_Combo = cc.ID_Combos\r\nleft join Cliente cl on ov.ID_Cliente = cl.ID_Cliente\r\nleft join Modo_Pago mp on ov.ID_Modo_Pago = mp.ID_Modo_Pago\r\n");

            return conn.EjecutarSentencia(mostrar);
        }

    }
}
