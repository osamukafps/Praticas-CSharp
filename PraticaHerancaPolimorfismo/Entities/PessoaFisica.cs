namespace PraticaHerancaPolimorfismo.Entities
{
    public class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set;}

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double renda, double gastosSaude)
            : base(nome, renda)
        {
            this.GastosComSaude = gastosSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - GastosComSaude * 0.50; 
            }
            
            else
            {
                return RendaAnual * 0.25 - GastosComSaude * 0.50;
            }
        }
    }
}