using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Entidades
{
    class Fatura
    {
        //uso do encapsulamento
        public double Pagamento { get; set; }
        public double Taxa { get; set; }


        //Criação do construtor
        public Fatura(double aluguel, double taxa)
        {
            Pagamento = aluguel;
            Taxa = taxa;
        }
        public double totalPagamento
        {
            get { return Pagamento + Taxa; }
        }
        //Está imprimindo o Pagamento Básico, Taxa e Pagamento Total
        public override string ToString()
        {
            return "Pagamento : "
            + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento Total: "
            + totalPagamento.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
