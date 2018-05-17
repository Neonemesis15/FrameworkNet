using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.CFG.JavaMovil
{
    public class HelperJson
    {
        public static string Serialize<T>(T obj)
        {
            string text = JsonConvert.SerializeObject(obj);
            return text;
        }

        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
