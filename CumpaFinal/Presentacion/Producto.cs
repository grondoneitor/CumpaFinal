using CumpaFinal.Datos;
using CumpaFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CumpaFinal.Presentacion
{
    public partial class Producto : Form
    {
        Datos_Productos prod;
        public Producto()
        {
            prod = new Datos_Productos();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
              prod.AgregarProductos(TomandoDatosProductos(), TomandoCategoria()) ;
            Cargando();

        }
        private void Producto_Load(object sender, EventArgs e)
        {

            Cargando();

        }


        public void Cargando()
        {
            Datos_Productos categoria = new Datos_Productos();

            cbxCategoria.DataSource = categoria.mostrarCategorias().Tables[0];
            cbxCategoria.DisplayMember = "Categoria_Producto";
            cbxCategoria.ValueMember = "Categoria_Producto";



            dgvProductos.DataSource = categoria.MostrarProductos().Tables[0];


        }

        public Logica_Producto TomandoDatosProductos()
        {
            Logica_Producto producto = new Logica_Producto();

            int ID = 0;
            int.TryParse(txtIDProveedor.Text, out ID);

            producto.ID = ID;
            producto.Producto = txtProductos.Text;
            producto.Color = txtColor.Text;
            producto.Tamaño = txtColor.Text;

            int Stock_Min = 0;
            int.TryParse(txtStock_Min.Text, out Stock_Min);
            producto.Stock_Minimo = Stock_Min;

            int Stock = 0;
            int.TryParse(txtStock.Text, out Stock);
            producto.Stock_Minimo = Stock;

            int Precio_Costo = 0;
            int.TryParse(txtCosto.Text , out Precio_Costo);
            producto.Precio_Costo = Precio_Costo;

            int Precio_Venta = 0;
            int.TryParse(txtPrecio_Venta.Text, out Precio_Venta);
            producto.Precio_Venta = Precio_Venta;

            producto.Nota = txtNota.Text;
            return producto;
        }

        public Logica_Categoria_Productos TomandoCategoria()
        {
            Logica_Categoria_Productos  cate = new Logica_Categoria_Productos();

            cate.Categoria = cbxCategoria.Text;
            return cate;
        }

    }
}
