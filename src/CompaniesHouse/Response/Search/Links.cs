﻿using Newtonsoft.Json;

namespace CompaniesHouse.Response.Search
{
    public class Links
    {
        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }
    }
}