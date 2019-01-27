using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace G_bot
{
    class Utilities
    {

        private static Dictionary<string,string> alerts;

        static Utilities() {


            string json = File.ReadAllText("systemlang/Alerts.json");

            var data = JsonConvert.DeserializeObject<dynamic>(json);

            alerts = data.ToObject<Dictionary<string,string>>();
            

        }

        public static string GetAlerts(string key) {

            if (alerts.ContainsKey(key)) return alerts[key];
            return "";
        }



    }


}
