using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{
    internal class Datos_Clientes
    {
       Conexion conn;
        public Datos_Clientes() 
        {
            conn = new Conexion();    
        }
       
    //public DataSet Agregar()
    //    {

    //    }
    
    public DataSet Mostrar()
        {
            SqlCommand mostrar = new SqlCommand("Select * From Cliente");
         
            return     conn.EjecutarSentencia(mostrar); 
        }
    }
}
