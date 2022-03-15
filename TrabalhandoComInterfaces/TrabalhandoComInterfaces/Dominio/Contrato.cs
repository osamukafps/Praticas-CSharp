using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComInterfaces.Dominio
{
    public class Contrato
    {
        public int Codigo { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int codigo, DateTime dataContrato, double valorTotal)
        {
            Codigo = codigo;
            DataContrato = dataContrato;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcelas>();
        }

        public void AdicionarParcela(Parcelas parcela)
        {
            Parcelas.Add(parcela);
        }

    }
}
