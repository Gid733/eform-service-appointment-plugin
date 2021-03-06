using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceAppointmentPlugin.OfficeApi
{
    class ItemCollection<T>
    {
        [JsonProperty(PropertyName = "value")]
        public List<T> Items { get; set; }
        [JsonProperty(PropertyName = "@odata.nextLink")]
        public string NextPageUrl { get; set; }
    }
}