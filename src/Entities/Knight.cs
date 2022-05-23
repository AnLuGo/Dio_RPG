namespace Dio_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name,int hp, int mp,int level,string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name +  " Atacou com a espada";
        }
    }
}