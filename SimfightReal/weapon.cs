using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimfightReal
{
    class weapon
    {

        static Random gen = new Random();  // static därför om alla har olika generators kommer dem slumpa lite samma tal i lite samma ordning: om static har de samma generator 
        
        public int damage(int damage)
        {
            
            minDamage = gen.Next(10, 20);
            maxDamage = gen.Next(20, 50);
            return gen.Next(minDamage, maxDamage);
            
        }

        
        protected int minDmg = 5;
        protected int maxDmg = 10;

        public virtual int Attack() // den här metoden kan ersättas is subklasser, man kan skriva över den här i subklasser
        {
            return gen.Next(minDamage , maxDamage);
        }
        
      public int minDamage;
      public int maxDamage;
        


      
    }
}
