using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_linguagem
{
    public class Jogos // classe refrente a API 
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
    
        public string ?Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public string ?ImagemUrl { get; set; }
        public string ?Plataforma { get; set; }
        public double Rating { get; set; }
        public int ?Metacritic { get; set; }
        public List<string> ?Generos { get; set; }
        public List<string> ?Desenvolvedores { get; set; }
        public List<string> ?Publicadores { get; set; }
        public string ?Website { get; set; }
        public int Playtime { get; set; }
        // Outros campos conforme necessário
    }


    //23b8648e1de24da8be568f63d9e1140b

}
