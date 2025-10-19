using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_linguagem
{
    public class RespostaApi
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string ?Name { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("metacritic")]
        public int ?Metacritic { get; set; }

        [JsonProperty("platforms")]
        public List<PlatformInfo> Platforms { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("developers")]
        public List<Developer> Developers { get; set; }

        [JsonProperty("publishers")]
        public List<Publisher> Publishers { get; set; }

        [JsonProperty("results")]
        public List<RespostaApi> Results { get; set; }
    }

    public class PlatformInfo
    {
        [JsonProperty("platform")]
        public Platform Platform { get; set; }
    }

    public class Platform
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Genre
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Developer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Publisher
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}


