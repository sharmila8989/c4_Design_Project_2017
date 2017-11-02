using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class GameController
    {
        public PlayerCharacter player;
        public NonPlayerCharacter enemy;

        public PlayerCharacter selectCharacter(string pPlayer)
        {
          
            // creates player
            if (pPlayer == "Mage")
                player = new Mage(50, 50, "Mage");
            else if (pPlayer == "Thief")
                player = new Thief(50, 50, "Thief");
            else if (pPlayer == "Warrior")
                player = new Warrior(50, 50, "Warrior");


            return player;


        }

        public int battlePhase()
        {
            string[] enemyNameArray = new string[] { "Gaint", "Dragon", "Ghan", "Phanthom" };
            int[] enemyBaseDamageArray = new int[] { 10, 20, 30, 40 };
            int[] enemyMaxHealthPointsArray = new int[] { 50, 60, 70, 80 };

            // Randomly slecting Enemy's for name, HealthPoints, baseDamage

            Random ran = new Random();
            int index = ran.Next(0, 4);

            enemy = new NonPlayerCharacter(enemyMaxHealthPointsArray[index], enemyMaxHealthPointsArray[index], enemyNameArray[index], enemyBaseDamageArray[index]);

            while(player.currentHealthPoints > 0 && enemy.currentHealthPoints > 0)
            {
                if()
                player.Attack(enemy,);
            }

        }

        
    }
}
