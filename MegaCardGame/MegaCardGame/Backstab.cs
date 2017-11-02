using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCardGame
{
    class Backstab: SpecialAttack
    {
        public Backstab(int pBaseDamage): base(pBaseDamage) { }
        public override int MakeAttack(NonPlayerCharacter pEnemy)
        {
            string comments = "The thief backstabs enemy";
            MessageBox.Show(comments);
            var vRandom = new Random();
            var vResult = vRandom.Next(0, 3);
            if (vResult < 2)
            {

                comments = "the hit is missed"; 
                pEnemy.currentHealthPoints -= (int)(0.5 * baseAttackDamage);
                return 0;

            }
            else if (vResult == 2)
            {
                comments = "backstabs sucessfully";
                pEnemy.currentHealthPoints -= (2 * baseAttackDamage);
                return 0;
            }
            else
                return 0;
        }
    }
}
