
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Thief: PlayerCharacter
    {
        public Thief(int pMaxHealthPoints, int pCurrentHealthPoints, string pCharacterName): base   (pMaxHealthPoints, pCurrentHealthPoints, pCharacterName)
        {
            specialAttack = new Backstab(10);
            normalAttack = new NormalAttack(10);
        }

    }
}
