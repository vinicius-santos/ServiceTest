using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.Models
{
    public class TimeVerify
    {
        static bool configTime()
        {
            List<Market> BoaConfigs;
            DateTime date = DateTime.Now;
            using (StreamReader r = new StreamReader("BoaConfig.json"))
            {
                string json = r.ReadToEnd();
                BoaConfigs = JsonConvert.DeserializeObject<List<Market>>(json);
            }

              if(date.DayOfWeek.Equals())


            return false;
        }


    }

}
