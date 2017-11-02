using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class SpecialAttack: Attack
    {
        public SpecialAttack(int pBaseDamage): base(pBaseDamage)
        { }
        public virtual int MakeAttack(NonPlayerCharacter pPlayer)
        {
            throw new NotImplementedException();

        }

    }
}
