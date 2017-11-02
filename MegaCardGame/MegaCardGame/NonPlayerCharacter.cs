using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class NonPlayerCharacter: Character
    {
        protected string enemyType;
        protected Attack enemyAttack;
        public NonPlayerCharacter (int pMaxHealthPoints, int pCurrentHealthPoints, string pEnemyTpe, int pBaseDamage) : base(pMaxHealthPoints, pCurrentHealthPoints)
        {
            enemyType = pEnemyTpe;
            baseDamage = pBaseDamage;
            enemyAttack = new NormalAttack(pBaseDamage);


        }
    }
}
