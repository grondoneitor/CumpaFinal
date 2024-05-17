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
            Dictionary<int, Type> mapaColumnaControl = new Dictionary<int, Type>();

            mapaColumnaControl.Add(0, typeof(TextBox)); 
            mapaColumnaControl.Add(1, typeof(ComboBox)); 
            mapaColumnaControl.Add(2, typeof(ComboBox));  
            mapaColumnaControl.Add(3, typeof(ComboBox)); 
            mapaColumnaControl.Add(4, typeof(ComboBox)); 
            mapaColumnaControl.Add(5, typeof(TextBox));
            mapaColumnaControl.Add(6, typeof(TextBox)); 
            mapaColumnaControl.Add(7, typeof(TextBox)); 
            mapaColumnaControl.Add(8, typeof(TextBox)); 
            mapaColumnaControl.Add(9, typeof(TextBox)); 


            List<TextBox> array = new List<TextBox> {txt0,txt5,txt6,txt7,txt8,txt9};
            List<ComboBox> combo = new List<ComboBox> { cbx1 ,cbx2,cbx3,cbx4 };    

            Seleccionar select = new Seleccionar(e.RowIndex, dgvOrden_Venta, array, combo, mapaColumnaControl);
            select.seleccionar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
