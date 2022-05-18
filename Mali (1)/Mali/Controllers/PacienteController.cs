using System;
using System.Collections.Generic;
using Mali.Clases;
using System.Linq;
using System.Web;

namespace Mali.Controllers
{
    public class PacienteController
    {
                public static List<Paciente> listaPaciente = new List<Paciente>();


        public static string addPaciente(string rut, string digitoVerificador, int edad, int telefono, string mail, string ocupacion)
        {
            try
            {
                Paciente e = new Paciente()
                {
                    Rut = rut,
                    DigitoVerificador = digitoVerificador,
                    Edad = edad,
                    Telefono = telefono,
                    Mail = mail,
                    Ocupacion = ocupacion
                    
                };

                listaPaciente.Add(e);
                return "Paciente Agregado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static Paciente Find(string rut)
        {

            foreach (Paciente item in listaPaciente)
            {
                if (rut == item.Rut)
                {
                    return item;
                }
            }
            return null;

        }
        public static List<Paciente> FindAll()
        {
            return listaPaciente;
        }
    }
}
