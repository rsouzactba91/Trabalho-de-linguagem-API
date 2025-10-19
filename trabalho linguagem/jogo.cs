using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_linguagem
{
    public class Jogo
    {
       
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Plataforma { get; set; }
            public DateTime DataLancamento { get; set; }
            public string ImagemUrl { get; set; }
            public float Rating { get; set; }
            public int? Metacritic { get; set; }
            public List<string> Generos { get; set; }
            public List<string> Desenvolvedores { get; set; }
            public List<string> Publicadores { get; set; }
        }

    }

