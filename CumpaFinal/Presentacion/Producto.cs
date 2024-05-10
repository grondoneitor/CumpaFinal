using CumpaFinal.Datos;
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
        public Producto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

    }
}
