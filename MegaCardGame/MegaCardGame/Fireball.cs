using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Fireball: SpecialAttack
    {
        public Fireball(int pBaseDamage): base(pBaseDamage) { }
        public override int MakeAttack(NonPlayerCharacter pNonPlayer)
        {
            // has 50% chance of doing 4 X Damage to enemy
            // has 50% chance of doing 1X Damage to self

            var vRandom = new Random();
            var vResult = vRandom.Next(0, 2);

            if (vResult == 0)
            {
                pNonPlayer.currentHealthPoints -= (4 * baseAttackDamage);
                return 0;
            }
            else if (vResult == 1)
            {
                return baseAttackDamage;
            }
            else
                return 0;

        }
    }
}
