using ExercicioEnumDois.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumDois.Entities
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public List<ItensPedido> ItensPedido { get; set; } = new List<ItensPedido>();

        public void AdicionarItem(ItensPedido item)
        {
            ItensPedido.Add(item);
        }

        public void RemoverItem(ItensPedido item)
        {
            ItensPedido.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            
            foreach(var item in ItensPedido)
            {
                total += item.SubTotal();
            }
           
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hora do pedido: " + Data);
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine(Cliente.ToString());
            int i = 1;
            foreach (var item in ItensPedido)
            {
                
                sb.AppendLine($"*Item #{i}*");
                sb.AppendLine(item.ToString());
                i++;
            }

            sb.AppendLine("Total do pedido: R$" + Total().ToString());

            sb.AppendLine("---------------||---------------");

            return sb.ToString();

        }

    }
}
