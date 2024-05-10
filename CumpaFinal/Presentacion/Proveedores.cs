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
    public partial class Proveedores : Form
    {
        Datos_Proveedores proveedor;
        public Proveedores()
        {
            proveedor = new Datos_Proveedores();
            InitializeComponent();
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            Cargando();

            Datos_Lugar provincia = new Datos_Lugar();
            cbxProvincia.DataSource = provincia.MostrarProvincia().Tables[0];
            cbxProvincia.DisplayMember = "Provincia";
            cbxProvincia.ValueMember = "Provincia";

            Datos_Lugar localidad = new Datos_Lugar();
            cbxLocalidad.DataSource = localidad.MostrarLocalidad().Tables[0];
            cbxLocalidad.DisplayMember = "Localidad";
            cbxLocalidad.ValueMember = "Localidad";

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            proveedor.Agregar(TomandoDatosPro(), TomandDatosPersonales());
            Cargando();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            proveedor.Modificar(TomandoDatosPro(), TomandDatosPersonales());
            Cargando();
        }
        public Logica_Proveedores TomandoDatosPro()
        {
            Logica_Proveedores proveedores = new Logica_Proveedores();  
            int ID = 0;
            int.TryParse(txtIDProveedor.Text, out ID);
            proveedores.ID_Proveedor = ID;
            proveedores.Proveedor = txtProveedor.Text;

            return proveedores;

        }
        public Persona TomandDatosPersonales()
        {
            Persona proveedor = new Persona
           (txtMail.Text, txtTelefono.Text, txtContacto.Text, txtDireccion.Text, cbxProvincia.Text, cbxLocalidad.Text);

            return proveedor;

        }
        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Cargando()
        {
            dgvProveedor.DataSource = proveedor.Mostrar().Tables[0];

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
