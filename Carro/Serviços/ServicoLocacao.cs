using Carro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Serviços
{
    class ServicoLocacao
    {
        //uso do encapsulamento
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        //Declara que isso faz parte da minha interface
        private ITaxaServico _taxaServico;

        //Criação do construtor
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }
        //Método do Processo da Fatura
        public void processoFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Saida.Subtract(aluguelCarro.Entrada);
            //Esta zerando o pagamento básico
            double Pagamento = 0.0;
            //Condicional dos pagamentos por Horas e Dias
            if (duracao.TotalHours <= 12.0)
            {
                Pagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                Pagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            //Está informando os valores da taxa BR
            double Taxa = _taxaServico.Taxa(Pagamento);
            //Está criando um objeto com o valor do  pagamento básico e da taxa
            aluguelCarro.Fatura = new Fatura(Pagamento, Taxa);
        }
    }
}
