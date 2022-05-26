namespace Abstraindo_um_jogo_de_RPG.src.Entities
{
    public class wizard: Hero 
     {
     public wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
    
         public string Attack(int Bonus){


            if (Bonus > 6) {
            
            return this.Name + " " + "Lançou magia super efetiva com bonus de " + " " +Bonus;
         } else   {
            return this.Name + " " + "Lançou magia com força fraca de bonus de  " + " " + Bonus;
        }

        }

        
     }

    
}