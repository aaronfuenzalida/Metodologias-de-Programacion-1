using System;
using System.IO;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models
{
    public class LectorDeArchivos : ManejadorObtencionDatos
    {
        private static LectorDeArchivos unicaInstancia;

        // ¡IMPORTANTE! Cambia esta ruta a donde tengas el datos.txt en tu PC
        private const string ruta_archivo = @"C:\Users\Aaron\Downloads\datos.txt";
        private StreamReader lector_de_archivos;

        private LectorDeArchivos()
        {
            lector_de_archivos = new StreamReader(ruta_archivo);
        }

        public static LectorDeArchivos GetInstance()
        {
            if (unicaInstancia == null)
            {
                unicaInstancia = new LectorDeArchivos();
            }
            return unicaInstancia;
        }

        public override int numero(int max, int opcion)
        {
            if (opcion == 3) // Atiende Archivo
            {
                string linea = lector_de_archivos.ReadLine();
                if (linea == null) return 0;
                // Casteamos a int porque tus fábricas esperan ints
                return (int)(Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max);
            }
            else if (sucesor != null) return sucesor.numero(max, opcion);
            return 0;
        }

        public override string cadena(int cant, int opcion)
        {
            if (opcion == 3)
            {
                string linea = lector_de_archivos.ReadLine();
                if (linea == null) return "";
                linea = linea.Substring(linea.IndexOf('\t') + 1);
                cant = Math.Min(cant, linea.Length);
                return linea.Substring(0, cant);
            }
            else if (sucesor != null) return sucesor.cadena(cant, opcion);
            return "";
        }
    }
}