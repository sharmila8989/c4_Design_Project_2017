using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Attack
    {
        protected int baseAttackDamage;

        public Attack(int pBaseAttackDamage)
        {
            baseAttackDamage = pBaseAttackDamage;
        }
        public virtual int MakeAttack(Character pCharacter)
        {
            throw new NotImplementedException();
        }
        
    }
}
