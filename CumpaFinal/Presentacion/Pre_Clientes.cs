﻿using CumpaFinal.Datos;
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
  
        public Pre_Clientes() : base()
        {
            cli = new Datos_Clientes();
            InitializeComponent();
            Logica_Datos_Personales datosPersonales = new Logica_Datos_Personales();  
            
        }
        
        
        
        private void Clientes_Load(object sender, EventArgs e)
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

        public void Cargando()
        {
            dgvCliente.DataSource = cli.Mostrar().Tables[0];
        }


        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

            int indice = e.RowIndex;
            txtIDCliente.Text = dgvCliente.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvCliente.Rows[indice].Cells[1].Value.ToString();
            txtApellido.Text = dgvCliente.Rows[indice].Cells[2].Value.ToString();
            txtMail.Text = dgvCliente.Rows[indice].Cells[3].Value.ToString();
            txtTelefono.Text = dgvCliente.Rows[indice].Cells[4].Value.ToString();
            txtContacto.Text = dgvCliente.Rows[indice].Cells[5].Value.ToString();
            txtDireccion.Text = dgvCliente.Rows[indice].Cells[6].Value.ToString();
            cbxProvincia.Text = dgvCliente.Rows[indice].Cells[7].Value.ToString();
            cbxLocalidad.Text = dgvCliente.Rows[indice].Cells[8].Value.ToString();


        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                cli.Modificar(TomandoDatos(), TomandoDatosPersonales());
                Cargando();
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cli.Agregar(TomandoDatos(), TomandoDatosPersonales());
            Cargando();
        }

        public Logica_Clientes TomandoDatos()
        {
            Logica_Clientes logica_Clientes = new Logica_Clientes();


            int ID = 0;
            int.TryParse(txtIDCliente.Text, out ID);
            logica_Clientes.ID_Cliente = ID;
            logica_Clientes.Nombre = txtNombre.Text;
            logica_Clientes.Apellido = txtApellido.Text;
      
            return logica_Clientes; 
        }
        public Logica_Datos_Personales TomandoDatosPersonales()
        {
            Logica_Datos_Personales datos_Personales = new Logica_Datos_Personales();
            datos_Personales.Mail = txtMail.Text;
            datos_Personales.Telefono = txtTelefono.Text;
            datos_Personales.Contacto = txtContacto.Text;
            datos_Personales.Direccion = txtDireccion.Text;
            datos_Personales.ID_Provincia = cbxProvincia.Text;
            datos_Personales.ID_Localidad = cbxLocalidad.Text;

            return datos_Personales; 
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}
