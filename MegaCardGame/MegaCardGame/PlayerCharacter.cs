using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class PlayerCharacter: Character
    {
        protected string characterName;
        protected NormalAttack normalAttack;
        protected SpecialAttack specialAttack;

        public PlayerCharacter(int pMaxHealthPoints, int pCurrentHealthPoints,  string pCharacterName): base(pMaxHealthPoints, pCurrentHealthPoints)
        {
            characterName = pCharacterName;
          
        }
        public void Attack(NonPlayerCharacter pEnemy, string choiceOfAttack)
        {
            
            if( choiceOfAttack == "special") 
            currentHealthPoints = currentHealthPoints - specialAttack.MakeAttack(pEnemy);
            else
                currentHealthPoints = currentHealthPoints - normalAttack.MakeAttack(pEnemy);

        }

    }
}S
