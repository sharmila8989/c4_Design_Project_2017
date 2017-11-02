using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Mage: PlayerCharacter
    {
        public Mage(int pMaxHealthPoints, int pCurrentHealthPoints, string pCharacterName): base(pMaxHealthPoints, pCurrentHealthPoints, pCharacterName)
        {
            specialAttack = new Fireball(10);
            normalAttack = new NormalAttack(10);

        }
    }
}
