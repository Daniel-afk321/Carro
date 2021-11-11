using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Entidades
{
    class AluguelCarro
    {
        //uso do encapsulamento
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }

        //Criação do construtor
        public AluguelCarro(DateTime entrada, DateTime saida, Veiculo veiculo)
        {
            Entrada = entrada;
            Saida = saida;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
