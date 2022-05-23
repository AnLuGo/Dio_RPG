namespace Dio_RPG.src.Entities
{
    public abstract class Hero 
    {
        public string Name;
        public int Level;
        public int Hp;
        public int Mp;
        public string HeroType;

        public Hero(string name,int hp, int mp,int level,string heroType){
            this.Name = name;
            this.Level = level;
            this.Mp = mp;
            this.Hp = hp;
            this.HeroType = heroType;
        }
        public Hero (){
            
        }


        public override string ToString(){
            return this.Name + "  "
            + this.Hp + " "
            + this.Mp + " "
            + this.HeroType + " "
            +this.Level;

        }
        
        public virtual string Attack(){
            return this.Name + " Atacou com sua espada de fogo";
        }
            
        
    }
}