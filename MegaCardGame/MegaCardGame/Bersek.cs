using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Bersek : SpecialAttack
    {
        public Bersek(int pBaseDamage) : base(pBaseDamage) { }
        public override int MakeAttack(NonPlayerCharacter pEnemy)
        {
            var vRandom = new Random();
            var vResult = vRandom.Next(0, 3);

            if (vResult < 2)
            {

                return 0;
            }
            else if (vResult == 2)
            {
                pEnemy.currentHealthPoints -= (2 * baseAttackDamage);
                return 0;
            }
            else
                return 0;
        }


    }
}
