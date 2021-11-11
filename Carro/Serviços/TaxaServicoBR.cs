using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Serviços
{
    //Ele está herdando as informações que vem do ITaxaServico
    class TaxaServicoBR : ITaxaServico
    {
        //Calculo da Taxa que sera seu valor
        public double Taxa(double quantidade)
        {
            if (quantidade <= 100.00)
            {
                return quantidade * 0.2;
            }
            else
            {
                return quantidade * 0.15;
            }
        }
    }
}
