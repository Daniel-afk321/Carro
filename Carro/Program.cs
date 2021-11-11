using Carro.Entidades;
using Carro.Serviços;
using System;
using System.Globalization;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensagem que irá aparecer ao usuário para entra com as informações de locação
            Console.WriteLine("Entre com os dados da locação:");
            //Usuário deve colocar o modelo do carro para a locação
            Console.Write("modelo: ");
            string modelo = Console.ReadLine();
            //Usuário entrara com a Data e com a Hora da locação
            Console.Write("Entrada (dd / MM / yyyy HH: mm): ");
             DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Usuário entrara com a saída da Data e da Hora da locação
            Console.Write("saida (dd / MM / yyyy HH: mm): ");
             DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Entrara com o preço por hora  
            Console.Write("Entre com o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Entrara com o preço por dia 
            Console.Write("Entre com preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Acada locação está sendo criado um objeto
            AluguelCarro aluguelCarro = new AluguelCarro(entrada, saida, new Veiculo(modelo));
            //Este Objeto contem horas, dias e a taxa do Brasil
            ServicoLocacao servicoLocacao = new ServicoLocacao(hora, dia, new TaxaServicoBR());
            //É a Fatura que irá aparecer para o usuário
            servicoLocacao.processoFatura(aluguelCarro);
            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
