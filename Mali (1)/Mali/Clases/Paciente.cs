using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mali.Clases
{
    public class Paciente
    {
        private string nombre;
        private string rut;
        private string digitoVerificador;
        private int edad;
        private int telefono;
        private string mail;
        private string ocupacion;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        public string DigitoVerificador
        {
            get { return digitoVerificador; }
            set { digitoVerificador = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }
        public FichaMedica FichaMedica
        {
            get { return fichaMedica; }
            set { fichaMedica = value; }
        }



    }
}