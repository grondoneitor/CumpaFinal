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
    public partial class Orden_Venta : Form
    {
        public Orden_Venta()
        {
            InitializeComponent();

            Pre_Clientes Cliente = new Pre_Clientes();
        }

        private void Orden_Venta_Load(object sender, EventArgs e)
        {

        }
    }
}
