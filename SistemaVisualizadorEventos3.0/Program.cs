using System.IO;
using System;
using System.Globalization;
using SistemaVisualizadorEventos3._0.Interfases;

namespace SistemaVisualizadorEventos3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fichero = @"Eventos.txt";

            ILeerFichero eventos = new LeerFichero();
            ComparaEventos dataEvent = new ComparaEventos();

            dataEvent.GetDatesOfFile((eventos.ReadFiles(fichero)));

            Console.ReadKey();
        }
    }
}