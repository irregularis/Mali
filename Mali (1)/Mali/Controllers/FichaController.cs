using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mali.Clases;

namespace Mali.Controllers
{
    public class FichaController
    {
        public static List<FichaMedica> listaFichaMedica = new List<FichaMedica>();


        public static string addFicha(Usuario profesional, DateTime fecha, string procedimiento, string motivoConsulta, string archivoConsulta, string detalleAplicacion, string enfermedadCronica, string medicamento, string cirugia, Paciente paciente)
        {
            try
            {
                FichaMedica e = new FichaMedica()
                {
                    Usuario = usuario,
                    Fecha = fecha,
                    Procedimiento = procedimiento,
                    MotivoConsulta = motivoConsulta,
                    ArchivosConsulta = archivoConsulta,
                    DetallesAplicacion = detalleAplicacion,
                    EnfermadadCronica = enfermedadCronica,
                    Medicamento = medicamento,
                    Cirugia = cirugia,
                    Paciente = paciente
                };

                listaFichaMedica.Add(e);
                return "Ficha Medica Agregada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static FichaMedica Find(int codigo)
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