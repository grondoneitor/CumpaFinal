﻿using CumpaFinal.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{
    internal class Datos_Productos
    {
        Conexion conn;
        public Datos_Productos()
        {
          conn = new Conexion();    
        }

        public DataSet AgregarProductos(Logica_Producto producto,Logica_Categoria_Productos categoria )
        {
            SqlCommand agregar = new SqlCommand($"exec AgregarProducto '{categoria.Categoria}','{producto.Producto}','{producto.Color}'," +
                $"'{producto.Tamaño}',{producto.Stock},{producto.Stock_Minimo},{producto.Precio_Costo},{producto.Precio_Venta},'{producto.Nota}'");

            return conn.EjecutarSentencia(agregar );
        }
        public DataSet MostrarProductos()
        {
            SqlCommand cmd = new SqlCommand($"select pp.ID_Productos, pp.Producto,cp.Categoria_Producto, pp.Color,pp.Tamaño,pp.Stock_Minimo,pp.Stock, " +
                $"pp.Precio_Costo,pp.Precio_Venta, pp.Nota\r\nfrom Productos pp \r\ninner join Categoria_Producto cp on pp.ID_Categoria_Producto = cp.ID_Categoria_Producto");


         return   conn.EjecutarSentencia(cmd);        
        }
    public DataSet mostrarCategorias()
        {
            SqlCommand motrar = new SqlCommand("select Categoria_Producto from Categoria_Producto\r\n");
            return conn.EjecutarSentencia(motrar); 

        }
    }

}
