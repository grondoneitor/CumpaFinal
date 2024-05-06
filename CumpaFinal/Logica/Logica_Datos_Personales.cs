using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Logica
{
    public class Logica_Datos_Personales
    { 
        public Logica_Datos_Personales(string mail,string telefono, string contacto, string direccion, string provincia, string localidad) 
        { 
           this.Mail = mail;
           this.Telefono = telefono;
           this.Contacto = contacto;
           this.Direccion  = direccion;
           this.ID_Provincia = provincia;
           this.ID_Localidad  = localidad;

        }

        public int ID_Datos_Personales { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string ID_Provincia {get; set; } 
        public string ID_Localidad { get; set; }   


        

    }
}
