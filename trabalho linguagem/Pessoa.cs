using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_linguagem
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? cpf { get; set; }
        public string? telefone { get; set; }
        public char sexo { get; set; }
        public DateTime nascimento { get; set; }
        public double peso { get; set; }
        public bool ativo { get; set; }
        public int matricula { get { return Gerarmatricula(); } }
        public bool pagamento { get; set; }
        public bool pagamentodevolucao { get; set; }
        public int pedido { get { return GerarPedido(); } }
        private int Gerarmatricula()
        {
            Random rd = new Random();
            int m = rd.Next(5000);
            return m;

        }

        private static int contadorPedido = 1;

        private int GerarPedido()
        {
            return contadorPedido++;
        }

    }
}