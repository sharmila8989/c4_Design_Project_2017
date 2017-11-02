using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class Warrior: PlayerCharacter
    {
        public Warrior(int pMaxHealthPoints, int pCurrentHealthPoints, string pCharacterName):base(pMaxHealthPoints, pCurrentHealthPoints, pCharacterName)
        {
            specialAttack = new Bersek(10);
            normalAttack = new NormalAttack(10);
        }
    }
}
