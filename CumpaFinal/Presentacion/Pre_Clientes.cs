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
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
