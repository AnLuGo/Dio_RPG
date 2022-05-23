namespace Dio_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name,int hp, int mp,int level,string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.HeroType = heroType;
            
        }
        public override string Attack(){
            return this.Name + " Lançou magia de fogo";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Lançou uma magia de fogo super efetiva com bonus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
            
        }
    }
    
}