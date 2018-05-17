using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ContentStringDataSet
    {
        public E_ContentStringDataSet()
        {
            ContentStringDataTables = new List<E_ContentStringDataTable>();
        }
        [JsonProperty("a")]
        public List<E_ContentStringDataTable> ContentStringDataTables { get; set; }

    }
    public class E_ContentStringDataTable
    {
        [JsonProperty("a")]
        public string[] Header { get; set; }

        [JsonProperty("b")]
        public string[][] Contents { get; set; }
    }
}
