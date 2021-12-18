using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumDois.Entities.Enums
{
    public enum StatusPedido : int
    {
        AguardandoPagamento = 0,
        SeparandoEmEstoque = 1,
        PedidoEnviado = 2,
        PedidoEntregue = 3
    }
}
