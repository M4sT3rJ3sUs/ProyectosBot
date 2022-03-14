using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVisualizadorEventos3._0.Interfases;

namespace SistemaVisualizadorEventos3._0
{
    internal class ComparaEventos : IComparaEventos
    {
        ComparaFechas dates = new ComparaFechas();
        public void GetDatesOfFile(string[] eventDates)
        {
            foreach (var evento in eventDates)
            {
                string[] date = evento.Split(",");
                string nameEvent = date[0];

                DateTime dateValue = DateTime.ParseExact(date[1], " dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
                var dateDifference = DateTime.Now - dateValue;

                dates.compareDateTimes(nameEvent, dateValue, dateDifference);
            }
        }
    }
}
