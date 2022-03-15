using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComInterfaces.Serviço
{
    interface IPagamentoOnlineService
    {
        double TaxaPagamento(double valor);
        double PagamentoMensal(double valor, int meses);
    }
}
