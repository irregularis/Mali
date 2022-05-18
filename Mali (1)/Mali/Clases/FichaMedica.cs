using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mali.Clases
{
    public class FichaMedica
    {
        
        private Usuario profesional;
        private DateTime fecha;
        private string procedimiento;
        private string motivoConsulta;
        private string archivosConsulta;
        private string detallesAplicacion;
        private string enfermedadCronica;
        private string medicamento;
        private string cirugia;
        private Paciente paciente;
           
        public Paciente Paciente 
        {
            get { return paciente; }
            set { paciente = value; }
        }


        public string Cirugia
        {
            get { return cirugia; }
            set { cirugias = value; }
        }


        public string Medicamento
        {
            get { return medicamento; }
            set { medicamentos = value; }
        }

        public string EnfermadadCronica
        {
            get { return enfermedadCronica; }
            set { enfermedadCronica = value; }
        }

        public string DetallesAplicacion
        {
            get { return detallesAplicacion; }
            set { detallesAplicacion = value; }
        }

        public string ArchivosConsulta
        {
            get { return archivosConsulta; }
            set { archivosConsulta = value; }
        }


        public string MotivoConsulta
        {
            get { return motivoConsulta; }
            set { motivoConsulta = value; }
        }

        public string Procedimiento
        {
            get { return procedimiento; }
            set { procedimiento = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Usuario Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

    }
}