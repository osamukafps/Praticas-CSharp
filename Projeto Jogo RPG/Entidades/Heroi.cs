namespace Projeto_Jogo_RPG.Entidades
{
    public class Heroi
    {
        public string Name;
        public int Level;
        public string HeroType;

        #region Constructors
        public Heroi()
        {

        }

        public Heroi(string name, int level, string type)
        {
            Name = name;
            Level = level;
            HeroType = type;
        }

        #endregion

        public override string ToString()
        {
            string heroi = $"{Name}\n {Level}\n {HeroType}";
            return heroi;   
        }

        public virtual string Attack()
        {
            return this.Name + " Has attacked with your sword!";
        }


    }
}