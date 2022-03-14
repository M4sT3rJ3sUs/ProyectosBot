using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVisualizadorEventos3._0.Interfases;

namespace SistemaVisualizadorEventos3._0
{
    internal class LeerFichero : ILeerFichero
    {
        public string[] ReadFiles(string fileLocation)
        {
            string[] events = File.ReadAllLines(fileLocation);
            return events;
        }
    }
}
