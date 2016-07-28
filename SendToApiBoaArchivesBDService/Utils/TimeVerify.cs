using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.Models
{

    /*
     Recebe o json com as configurações do mercado e verifica se o dia  hora condizem com o esperado se sim retorna true.
         */

    public class TimeVerify
    {
        public static string verifyRunTask(string jsonParameters)
        {
            List<JsonValues> DateConfigs;
            DateTime date = DateTime.Now;
            using (StreamReader r = new StreamReader(jsonParameters))
            {
                string json = r.ReadToEnd();
                DateConfigs = JsonConvert.DeserializeObject<List<JsonValues>>(json);
            }
            foreach (var marketDates in DateConfigs)
            {
                string Day = marketDates.Day.TrimStart('"').TrimEnd('"');
                
                int Hour = Convert.ToInt16(marketDates.Hour);
                string DiaSemana = date.DayOfWeek.ToString();
                if (!String.IsNullOrEmpty(marketDates.Minutes))
                {
                    int Minutes = Convert.ToInt16(marketDates.Minutes);
                    if ((DiaSemana.Equals(Day)) && (date.Hour.Equals(Hour)) && (date.Minute.Equals(Minutes)))
                    {
                        return marketDates.TypeDB;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (date.DayOfWeek.ToString().Equals(Day) && (date.Hour.Equals(Hour)))
                    {
                        return marketDates.TypeDB;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return null;
        }
    }
}
