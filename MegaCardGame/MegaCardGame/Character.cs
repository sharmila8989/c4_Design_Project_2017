using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Character
    {
        protected int baseDamage;
        public int currentHealthPoints;
        protected int maxHealthPoints;

        public Character(int pMaxHealthPoints, int pCurrentHealthPoints)
        {
            maxHealthPoints = pMaxHealthPoints;
            currentHealthPoints = pCurrentHealthPoints;
            
            

        }

        public void Attack(int pBaseDamage)
        {

        }
    }
}
