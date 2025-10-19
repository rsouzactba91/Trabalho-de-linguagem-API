using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_linguagem
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string? Cep { get; set; }

        [JsonProperty("logradouro")]
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }

        [JsonProperty("bairro")]
        public string? Bairro { get; set; }

        [JsonProperty("localidade")]
        public string? Cidade { get; set; }

        [JsonProperty("uf")]
        public string? UF { get; set; }
    }
}

