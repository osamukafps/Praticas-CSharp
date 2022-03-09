namespace PraticaHerancaPolimorfismo.Entities
{
    public class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios  {get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double renda, int numeroFuncionarios)
            : base(nome, renda)
        {
            NumeroDeFuncionarios = numeroFuncionarios;
        }
        
        public override double Imposto()
        {
            if(NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }

            else
            {
                return RendaAnual * 0.16;
            }

        }
    }
}