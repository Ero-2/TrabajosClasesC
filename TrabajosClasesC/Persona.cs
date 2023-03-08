using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosClasesC
{
    internal class Persona
    {
        protected String nombre;
        protected DateTime? fechaNacimiento;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                int dia;
                int mes;
                int edad;
                edad = (DateTime.Now.Year - fechaNacimiento.Value.Year);
                mes = (DateTime.Now.Month - fechaNacimiento.Value.Month);
                dia = (DateTime.Now.Day - fechaNacimiento.Value.Day);

                if (mes >= 0)
                {
                    if (dia < 0)
                    {
                        edad--;
                    }
                }
                if (mes < 0)
                {
                    edad--;
                }


                return edad;

            }

        }
        public Persona()
        {
            nombre = String.Empty;
            fechaNacimiento = null;//DateTime.MinValue;
        }
        public Persona(String nombre, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return nombre.ToUpper() + " " + Edad;
        }

    }
}

