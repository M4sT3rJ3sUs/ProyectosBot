using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizadorEventos3._0
{
    internal class ConversorEventos
    {
        public void compareConvertedDates(string eventStatus, int minutes, int hours, int days, int months)
        {
            if (minutes < 60)
            {
                eventStatus += " " + minutes + " minutos";
            }
            else if (hours < 24 && minutes >= 60)
            {
                eventStatus += " " + hours + " horas";
            }
            else if (days < 30)
            {
                eventStatus += " " + days + " dias";
            }
            else if (days >= 30)
            {
                eventStatus += " " + months + " meses";
            }
            Console.WriteLine(eventStatus);
        }
    }
}
