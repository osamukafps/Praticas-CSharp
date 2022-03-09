namespace Projeto_Jogo_RPG.Entidades
{
    public class Mago : Heroi
    {
        public Mago()
        {

        }

         public Mago(string name, int level, string type)
        {
            Name = name;
            Level = level;
            HeroType = type;
        }
        public override string Attack()
        {
            return this.Name + " threw a fireball!";
        }
    }
}