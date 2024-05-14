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


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Seleccionar(i);
        }
        private void Producto_Load(object sender, EventArgs e)
        {

            Cargando();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
              prod.AgregarProductos(TomandoDatosProductos(), TomandoCategoria()) ;
            Cargando();
            Limpiar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            prod.ModificarProductos(TomandoDatosProductos(), TomandoCategoria());
            Cargando();
            Limpiar();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            prod.EliminarProductos(TomandoDatosProductos());
            Cargando();
            Limpiar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Cargando()
        {
            Datos_Productos categoria = new Datos_Productos();

            cbxCategoria.DataSource = categoria.mostrarCategorias().Tables[0];
            cbxCategoria.DisplayMember = "Categoria_Producto";
            cbxCategoria.ValueMember = "Categoria_Producto";



            dgvProductos.DataSource = categoria.MostrarProductos().Tables[0];


        }
        public void Seleccionar(int e)
        {
            txtIDProducto.Text = dgvProductos.Rows[e].Cells[0].Value.ToString();
            txtProductos.Text = dgvProductos.Rows[e].Cells[1].Value.ToString();
            cbxCategoria.Text = dgvProductos.Rows[e].Cells[2].Value.ToString();
            txtColor.Text = dgvProductos.Rows[e].Cells[3].Value.ToString();
            cbxTamaño.Text = dgvProductos.Rows[e].Cells[4].Value.ToString();
            txtStock_Min.Text = dgvProductos.Rows[e].Cells[5].Value.ToString();
            txtStock.Text = dgvProductos.Rows[e].Cells[6].Value.ToString();
            txtCosto.Text = dgvProductos.Rows[e].Cells[7].Value.ToString();
            txtPrecio_Venta.Text = dgvProductos.Rows[e].Cells[8].Value.ToString();
            txtNota.Text = dgvProductos.Rows[e].Cells[9].Value.ToString();
        }

        public Logica_Producto TomandoDatosProductos()
        {
            Logica_Producto producto = new Logica_Producto();

            int ID = 0;
            int.TryParse(txtIDProducto.Text, out ID);

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

        public void Limpiar()
        {
            txtIDProducto.Text = "";
            txtProductos.Text = "";
            cbxCategoria.Text = "";
            txtColor.Text = "";
            cbxTamaño.Text = "";
            txtStock_Min.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtPrecio_Venta.Text = "";
            txtNota.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
