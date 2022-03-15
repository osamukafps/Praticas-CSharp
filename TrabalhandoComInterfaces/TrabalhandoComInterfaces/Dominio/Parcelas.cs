using System;
using System.Globalization;

namespace TrabalhandoComInterfaces.Dominio
{
    public class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public Parcelas(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("d")
                   + " - "
                   + "R$" + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
