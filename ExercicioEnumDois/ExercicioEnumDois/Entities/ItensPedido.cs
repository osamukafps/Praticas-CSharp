using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumDois.Entities
{
    public class ItensPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItensPedido()
        {

        }

        public ItensPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Produto: " + Produto.Nome);
            sb.AppendLine("Preço Un. : R$" + Produto.Preco);
            sb.AppendLine("Quantidade: " + Quantidade.ToString());
            sb.AppendLine("Preço total: R$" + SubTotal());

            return sb.ToString();

        }
    }
}
