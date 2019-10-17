using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimfightReal
{
    class karaktär
    {
        public int hp = 20;
        public void Attack(karaktär opponent)
        {
            opponent.Hurt(5);
           
        }
        public virtual void Hurt(int amount)
        {
            amount = Math.Max(0, amount);
            hp -= amount;
        }
    }
}
