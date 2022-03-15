using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComInterfaces.Dominio;

namespace TrabalhandoComInterfaces.Serviço
{
    class ContratoService
    {
        private IPagamentoOnlineService _pagamentoOnlineService;

        public ContratoService(IPagamentoOnlineService pagamentoOnlineService)
        {
            _pagamentoOnlineService = pagamentoOnlineService;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double pagamento = contrato.ValorTotal / meses;

            for(int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double pagamentoAtualizado = pagamento + _pagamentoOnlineService.PagamentoMensal(pagamento, i);
                double pagamentoTotal = pagamentoAtualizado + _pagamentoOnlineService.TaxaPagamento(pagamentoAtualizado);
                contrato.AdicionarParcela(new Parcelas(data, pagamentoTotal));
            }
        }
    }
}
