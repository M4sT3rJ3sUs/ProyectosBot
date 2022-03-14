using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizadorEventos3._0
{
    internal class ComparaFechas
    {
        private int minutes, hours, days, months;
        public void compareDateTimes(string nameEvent, DateTime dateValues, TimeSpan dateDifference)
        {
            string eventStatus = nameEvent;
            if (dateValues < DateTime.Now)
            {
                eventStatus += " ocurrio hace:";
            }
            else
            {
                dateDifference = dateValues - DateTime.Now;
                eventStatus += " ocurrira dentro de:";
            }
            ConvertAllToMinutes(eventStatus, dateDifference);
        }

        private void ConvertAllToMinutes(string eventStatus, TimeSpan dateDifference)
        {
            ConversorFechas dateConvert = new ConversorFechas();

            minutes = (int)dateDifference.TotalMinutes;
            hours = dateConvert.MinuteToHour(minutes);
            days = dateConvert.HourToDays(hours);
            months = dateConvert.DaysToMonths(days);

            ConversorEventos printConvertedEventDates = new ConversorEventos();
            printConvertedEventDates.compareConvertedDates(eventStatus, minutes, hours, days, months);
        }
    }
}
