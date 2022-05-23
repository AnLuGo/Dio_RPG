namespace Dio_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string name,int hp, int mp,int level,string heroType){
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.HeroType = heroType;
        }


        public override string Attack()
        {
            return this.Name +  " Lançou feitiço bola de fogo";
        }
    }
}