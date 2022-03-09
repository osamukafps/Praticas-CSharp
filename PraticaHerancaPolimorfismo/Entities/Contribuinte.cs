namespace PraticaHerancaPolimorfismo.Entities
{
    public abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte()
        {

        }

        public Contribuinte(string nome, double renda)
        {
            this.Nome = nome;
            this.RendaAnual = renda;
        }

        public abstract double Imposto();
    }
}