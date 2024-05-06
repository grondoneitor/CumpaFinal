using CumpaFinal.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Presentacion
{
    public  class Persona : Logica_Datos_Personales
    {
        Logica_Datos_Personales datos_Personales;
        public Persona(string txtMail, string txtTelefono, string txtContacto, string txtDireccion, string txtProvincia, string txtLocalidad) : base(txtMail,txtTelefono, txtContacto, txtDireccion, txtProvincia, txtLocalidad )
        {
        
            this.TxtMail = txtMail;
            this.TxtTelefono = txtTelefono;
            this.TxtContacto = txtContacto;
            this.TxtDireccion = txtDireccion;
            this.TxtProvincia = txtProvincia;
            this.TxtLocalidad = txtLocalidad;
        }

        public string TxtMail { get; set; }
        public string TxtTelefono { get; set; }
        public string TxtContacto { get; set; }
        public string TxtDireccion { get; set; }
        public string TxtProvincia { get; set; }
        public string TxtLocalidad { get; set; }

        //Aca pedimos los datos personales

        public virtual Logica_Datos_Personales TomandoDatos() 
        {

            this.Mail = TxtMail;
            this.Telefono = TxtTelefono;
            this.Contacto = TxtContacto;
            this.Direccion = TxtDireccion;
            this.ID_Provincia = TxtProvincia;
            this.ID_Localidad = TxtLocalidad;

            return this;
        }

      

    }
}
