using Mali.Clases;
using System;
using System.Collections.Generic;

namespace Mali.Controllers
{
    public class UsuarioController
    {
        private static List<Usuario> listaEncargado = new List<Usuario>(); 
        
        //Método de registro.
        public static string AddUsuario(string rut, string contraseña, string nombre, DateTime fechaCreacion, string estado, DateTime fechaEstado, string rango)
        {
            try
            {
                Usuario u = new Usuario()
                {
                    Rut = rut,
                    Contraseña = contraseña,
                    Nombre = nombre,
                    FechaCreacion = fechaCreacion,
                    string


                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}