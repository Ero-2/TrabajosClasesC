using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosClasesC
{
    internal class contacto: Persona
    {
        private string telefono;
        private string correo;
        public string telefono_
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = telefono_;
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }



        public string Correo

        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono { get; internal set; }

        public contacto() : base()
        {
            telefono = string.Empty;
            correo = string.Empty;
        }
        public contacto(string nombre, DateTime fechaDenacimiento, string telefono) : base(nombre, fechaDenacimiento)
        {
            this.telefono = telefono;
            this.correo = correo;
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono + " " + correo;
        }
    }
}

