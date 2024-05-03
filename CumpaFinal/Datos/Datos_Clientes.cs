using CumpaFinal.Logica;
using CumpaFinal.Presentacion;
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
       
    public DataSet Agregar(Logica_Clientes clientes, Logica_Datos_Personales datos)
    {
            SqlCommand agregar = new SqlCommand($" exec  InsertarCliente " +
                $"'{clientes.Nombre}','{clientes.Apellido}','{datos.Mail}','{datos.Contacto}','{datos.Telefono}'," +
                $"'{datos.Direccion}','{datos.ID_Provincia}','{datos.ID_Localidad}'");

            return conn.EjecutarSentencia( agregar );
    }
    public DataSet Modificar(Logica_Clientes clientes, Logica_Datos_Personales datos)
        {
            SqlCommand modificar = new SqlCommand($"\t  exec ActualizarCliente " +
                $"{clientes.ID_Cliente},'{clientes.Nombre}','{clientes.Apellido}'," +
                $"'{datos.Mail}','{datos.Telefono}','{datos.Contacto}','{datos.Direccion}', '{datos.ID_Provincia}','{datos.ID_Localidad}'");
            return conn.EjecutarSentencia(modificar);
        }
    public DataSet Mostrar()
        {
            SqlCommand mostrar = new SqlCommand("\t  select cc.ID_Cliente ,cc.Nombre, cc.Apellido, dd.Mail, dd.Telefono, dd.Contacto, dd.Direccion, pp.Provincia, ll.Localidad\r\n\t  from Cliente cc\r\n\t  inner join Datos_Personales dd on cc.ID_Datos_Personales = dd.ID_Datos_Personales\r\n\t  inner join Localidades ll on dd.ID_Localidad = ll.ID_Localidades\r\n\t  inner join Provincia pp on ll.ID_Provincias = pp.ID_Provincia");
         
            return     conn.EjecutarSentencia(mostrar); 
        }
    }
}
