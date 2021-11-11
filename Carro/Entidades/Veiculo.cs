using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Entidades
{
    class Veiculo
    {
        //uso do encapsulamento
        public string Modelo { get; set; }


        //Criação do construtor
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
