using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVisualizadorEventos3._0.Interfases;

namespace SistemaVisualizadorEventos3._0
{
    internal class ConversorFechas : IConversorFechas
    {
        public int MinuteToHour(int minutes)
        {
            return minutes / 60;
        }
        public int HourToDays(int hours)
        {
            return hours / 24;
        }
        public int DaysToMonths(int days)
        {
            return days / 31;
        }
    }
}
