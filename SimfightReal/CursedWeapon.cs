using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimfightReal
{
    class CursedWeapon: weapon
    {
        // gör alltid min skada
        public override int Attack()
        {
            return minDamage;
        }

    }
}
