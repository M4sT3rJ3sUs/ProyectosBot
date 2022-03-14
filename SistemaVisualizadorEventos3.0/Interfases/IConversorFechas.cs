using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizadorEventos3._0.Interfases
{
    internal interface IConversorFechas
    {
        int MinuteToHour(int minutes);
        int HourToDays(int hours);
        int DaysToMonths(int days);
    }
}
