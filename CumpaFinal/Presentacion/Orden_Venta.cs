using CumpaFinal.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CumpaFinal.Presentacion
{
    public partial class Orden_Venta : Form
    {
        Datos_Orden_Venta orden;
        public Orden_Venta()
        {
            orden = new Datos_Orden_Venta();
            InitializeComponent();

            Pre_Clientes Cliente = new Pre_Clientes();
        }

        private void Orden_Venta_Load(object sender, EventArgs e)
        {
            dgvOrden_Venta.DataSource = orden.MostrarOrden().Tables[0];
        }


   

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Seleccionar(i);
           
        }

        public void Seleccionar(int i)
        {
            Dictionary<string, Type> tabla = new Dictionary<string, Type>();
            tabla.Add(txtID_Orden_Venta.Name, txtID_Orden_Venta.GetType());
            tabla.Add(cbxProducto.Name, cbxProducto.GetType());
            tabla.Add(cbxCombo.Name, cbxCombo.GetType());
            tabla.Add(cbxCliente.Name, cbxCliente.GetType());
            tabla.Add(cbxModo_Pago.Name, cbxModo_Pago.GetType());
            tabla.Add(txtCantidad.Name, txtCantidad.GetType());
            tabla.Add(txtFecha_Venta.Name, txtFecha_Venta.GetType());
            tabla.Add(txtTotal.Name, txtTotal.GetType());
            tabla.Add(txtEstado_Pedido.Name, txtEstado_Pedido.GetType());
            tabla.Add(txtNota.Name, txtNota.GetType());


            Seleccionar select = new Seleccionar(i, dgvOrden_Venta,tabla, this);
            select.seleccionar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
