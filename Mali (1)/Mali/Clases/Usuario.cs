using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mali.Clases
{
    public class Usuario{
        private string rut;
        private string contraseña;



        private string nombre;
        private DateTime fechaCreacion;
        private string estado;
        private DateTime fechaEstado;
        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public DateTime FechaEstado
        {
            get { return fechaEstado; }
            set { fechaEstado = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

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
        

        public string Contraseña{
            get { return contraseña; }
            set { contraseña = value; }
        }

     
    }
}