using System;
using Newtonsoft.Json;

namespace Core.Entities
{
    public class BaseEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime? DateCreated { get; set; }
       
    }
}