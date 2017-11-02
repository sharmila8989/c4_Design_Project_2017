using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class NormalAttack : Attack
    {
        public NormalAttack(int pBaseAttackDamage): base(pBaseAttackDamage) { }

        public override int MakeAttack(Character pCharacter)
        {
            pCharacter.currentHealthPoints -= baseAttackDamage;
            return 0;
        }

    }
}
