using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimfightReal
{
    class weapon
    {

        Random gen = new Random();  
        
        public int damage(int damage)
        {
            
            minDamage = gen.Next(10, 20);
            maxDamage = gen.Next(20, 50);
            return gen.Next(minDamage, maxDamage);
        }
        
        public int PrintStat(int PrintStat)
        {
            PrintStat
        }
        
      public int minDamage;
      public int maxDamage;

        
    }
}
