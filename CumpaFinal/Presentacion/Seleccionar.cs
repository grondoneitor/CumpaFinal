using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CumpaFinal.Presentacion
{
    internal class Seleccionar
    {

        public Seleccionar(int indice, DataGridView dgv, List<System.Windows.Forms.TextBox> textboxes, List<System.Windows.Forms.ComboBox> comboboxes, Dictionary<int, Type> mapaColumnaControl) 
        {
            this.Indice = indice;
            this.Dgv = dgv;
            this.Textboxes = textboxes;
           this.Comboboxes = comboboxes;   
           this.MapaColumnaControl = mapaColumnaControl;
        }
        public int Indice { get; set; } 
        public DataGridView Dgv { get; set;}
        public List<System.Windows.Forms.TextBox> Textboxes { get; set; }
        public List<System.Windows.Forms.ComboBox> Comboboxes { get; set; }
        public Dictionary<int, Type> MapaColumnaControl { get; set; }

        public void seleccionar()
        {
            // Definir un diccionario para mapear índices de columna a tipos de control

            int indiceCells = 0;
            int indiceTextBox = 0;
            int indiceComboBox = 0;

            foreach (KeyValuePair<int, Type> entrada in MapaColumnaControl)
            {
         

                if (entrada.Value == typeof(System.Windows.Forms.TextBox))
                {
                    //indiceTextBox = entrada.Key;// Asignar datos a los TextBoxes
                    Textboxes[indiceTextBox].Text = Dgv.Rows[Indice].Cells[indiceCells].Value?.ToString() ?? "";
                    indiceCells++;
                    indiceTextBox++;
                }
                else if (entrada.Value == typeof(System.Windows.Forms.ComboBox))
                {
                    //indiceComboBox = entrada.Key;
                    Comboboxes[indiceComboBox].Text = Dgv.Rows[Indice].Cells[indiceCells].Value?.ToString() ?? "";
                    indiceCells++;
                    indiceComboBox++;
                }

                //Type tipoControl = entrada.Value;

      
            }

            //Indice++; // Incrementar el índice de la fila después de procesar todos los controles
        }



    }
}
