using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComInterfaces.Serviço
{
    public class PaypalService : IPagamentoOnlineService
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JurosMensal = 0.01;

        public double TaxaPagamento(double valor)
        {
            return valor * PorcentagemTaxa;
        }

        public double PagamentoMensal(double valor, int meses)
        {
            return valor * JurosMensal * meses;
        }
    }
}
