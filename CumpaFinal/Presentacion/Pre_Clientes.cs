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
    public partial class Pre_Clientes : Form
    {
        Datos_Clientes cli;
        public Pre_Clientes()
        {
            cli = new Datos_Clientes();
            InitializeComponent();
        }
        
        
        
        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cli.Mostrar().Tables[0];

            Datos_Lugar provincia = new Datos_Lugar();
            cbxProvincia.DataSource = provincia.MostrarProvincia().Tables[0];
            cbxProvincia.DisplayMember = "Provincia";
            cbxProvincia.ValueMember = "Provincia";

            Datos_Lugar localidad = new Datos_Lugar();
            cbxLocalidad.DataSource = localidad.MostrarLocalidad().Tables[0];
            cbxLocalidad.DisplayMember = "Localidad";
            cbxLocalidad.ValueMember = "Localidad";



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Logica_Clientes logica_Clientes = new Logica_Clientes();

            int indice = e.RowIndex;

            txtNombre.Text = dgvCliente.Rows[indice].Cells[1].Value.ToString();
            txtApellido.Text = dgvCliente.Rows[indice].Cells[2].Value.ToString();


        }
    }
}
