using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CumpaFinal.Presentacion
{
    internal class Seleccionar
    {

        public Seleccionar(int indice, DataGridView dgv,  Dictionary<string, Type> datos, Form formulario) 
        {
            this.Indice = indice;
            this.Dgv = dgv;

            List<System.Windows.Forms.TextBox> textBoxList = new List<System.Windows.Forms.TextBox>();
            List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();

            foreach (var kvp in datos)
            {
                if (kvp.Value == typeof(System.Windows.Forms.TextBox))
                {
                    // Obtener el control TextBox por su nombre utilizando el método Find()
                    Control control = formulario.Controls.Find(kvp.Key, true).FirstOrDefault();

                    // Verificar si el control encontrado es un TextBox
                    if (control is System.Windows.Forms.TextBox textBox)
                    {
                        // Agregar el TextBox a la lista
                        textBoxList.Add(textBox);
                    }
                }
                else if(kvp.Value == typeof(System.Windows.Forms.ComboBox))
                {
                    // Obtener el control TextBox por su nombre utilizando el método Find()
                    Control control = formulario.Controls.Find(kvp.Key, true).FirstOrDefault();

                    // Verificar si el control encontrado es un TextBox
                    if (control is System.Windows.Forms.ComboBox comboBox)
                    {
                        // Agregar el TextBox a la lista
                        comboBoxList.Add(comboBox);
                    }
                }
            }



            this.Textboxes = textBoxList;
            this.Comboboxes = comboBoxList;   
            this.MapaColumnaControl = datos;
        }
        public int Indice { get; set; } 
        public DataGridView Dgv { get; set;}
        public List<System.Windows.Forms.TextBox> Textboxes { get; set; }
        public List<System.Windows.Forms.ComboBox> Comboboxes { get; set; }
        public Dictionary<string, Type> MapaColumnaControl { get; set; }

        public void seleccionar()
        {
            // Definir un diccionario para mapear índices de columna a tipos de control

            int indiceCells = 0;
            int indiceTextBox = 0;
            int indiceComboBox = 0;

            foreach (KeyValuePair<string, Type> entrada in MapaColumnaControl)
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

            Indice++; // Incrementar el índice de la fila después de procesar todos los controles
        }



    }
}
