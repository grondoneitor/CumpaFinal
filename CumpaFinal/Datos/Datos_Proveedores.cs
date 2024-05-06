using CumpaFinal.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{

    internal class Datos_Proveedores
    {
        Conexion conn;
        public Datos_Proveedores()
        {
            conn = new Conexion();
        }

        public DataSet Agregar(Logica_Proveedores proveedor, Logica_Datos_Personales datos)
        {
            SqlCommand agregar =    new SqlCommand($"\texec IngresarProveedor" +
                $" '{proveedor.Proveedor}','{datos.Mail}', '{datos.Telefono}','{datos.Contacto}','{datos.Direccion}'," +
                $"'{datos.ID_Provincia}','{datos.ID_Localidad}'");
       
           return conn.EjecutarSentencia( agregar );
        }


        public DataSet Mostrar()
        {
            SqlCommand mostrar = new SqlCommand($"select pp.ID_Proveedor ,pp.Proveedor,dd.Mail,dd.Telefono,dd.Contacto,dd.Direccion,rr.Provincia,ll.Localidad\r\nfrom Proveedores pp \r\ninner join Datos_Personales dd on pp.ID_Datos_Personales = dd.ID_Datos_Personales\r\ninner join Localidades ll on dd.ID_Localidad=ll.ID_Localidades\r\ninner join Provincia rr on dd.ID_Provincia = rr.ID_Provincia");
      
             return conn.EjecutarSentencia( mostrar );  
        }


    }
}
