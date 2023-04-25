using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySp1Clinica_Cantallops
{
    public class ClsArchivo
    {
        public string NombreArchivo { get; set; }

        public bool GrabarMedico(ClsMedico registro)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(registro.matricula + "," + registro.nombre + "," + registro.especialidad);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool GrabarEspecialidad(ClsMedico registro)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(registro.especialidad + "," + registro.nombre);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool BuscarRepetido(string repetido)
        {
            bool resultado = false;
            string Linea;
            string Matricula;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    Matricula = Linea.Split(',')[0];
                    if(repetido == Matricula)
                    {
                        resultado = true;
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            return resultado;
        }

        public List<ClsMedico> ObtenerMedicos()
        {
            List<ClsMedico> Lista = new List<ClsMedico>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader (NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    ClsMedico Medico = new ClsMedico();
                    Medico.matricula = int.Parse(Linea.Split(',')[0]);
                    Medico.nombre = Linea.Split(',')[1];
                    Medico.especialidad = int.Parse(Linea.Split(',')[2]);
                    Lista.Add(Medico);

                }
                sr.Close();
                sr.Dispose();
            }
            return Lista;
        }

        public List<ClsMedico> ObtenerEspecialidad()
        {
            List<ClsMedico> lista = new List<ClsMedico> ();
            string linea;
            if(NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while(sr.EndOfStream == false)
                {
                    linea = sr.ReadLine();
                    ClsMedico especialidad = new ClsMedico();
                    especialidad.especialidad = int.Parse(linea.Split(',')[0]);
                    especialidad.nombre = linea.Split(',')[1];
                    lista.Add(especialidad);
                }
                sr.Close();
                sr.Dispose();
            }
            return lista;
        }

    }
}
