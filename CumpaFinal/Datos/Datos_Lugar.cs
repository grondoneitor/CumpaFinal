using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{
    internal class Datos_Lugar
    {
        Conexion conn;
        public Datos_Lugar() 
        {
            conn = new Conexion();
        }
       
      public DataSet MostrarProvincia () 
        {
            SqlCommand mostrar = new SqlCommand("select Provincia from Provincia");

            return conn.EjecutarSentencia(mostrar);    
        }

    }
}
