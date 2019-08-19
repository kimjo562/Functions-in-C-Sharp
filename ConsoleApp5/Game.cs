using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First Function and Arguments
/*
namespace ConsoleApp5
{
    class Game
    {
        int playerHealth = 100;
        int monsterDamage = 30;

        public int damage { get; private set; }

        public void Start()                                         // Start is the Function's Name         [public] means other classes/files can use this function.  [private] means denies others.
        {
            Console.WriteLine("My game has begun.");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttacks(monsterDamage * 2);
            MonsterAttacks(monsterDamage);                                       // Typing it three times tells that the monster attacks 3 times (Using MonsterAttacks() for first code)
            MonsterAttacks(monsterDamage * 3);

            damage = 5;
        }

        private void MonsterEncounter()
        {
            Console.WriteLine("A Monster appears!");
            Console.ReadKey();
        }

        /*
        private void MonsterAttacks()
        {
            playerHealth -= monsterDamage; // [*] 2;    // <----- makes it so it does double damage              Self Note: (Ignore [] compensating for comment line)
            Console.WriteLine("The Monster attacks you for " + monsterDamage /* 2 [*]//+ " points of damage.\n");
            Console.WriteLine("You have " + playerHealth + " health left.");
            Console.ReadKey();  
        }
        */ // Self Note: Keep this when removing entire comment

/*
        private void MonsterAttacks(int damage)
        {
            int combo = 0;
            combo += 1;
            playerHealth -= damage;
            Console.WriteLine("The Monster attacks you for " + damage + " points of damage.\n");
            Console.WriteLine("You have " + playerHealth + " health left.");
            Console.ReadKey();
        }
    }
}
*/

// Return Values
namespace ConsoleApp5
{
    class Game
    {
        int numberOne = 10;
        int numberTwo = 200;
        public void Start()
        {
            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);
            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggest number is " + biggestNumber);
            Console.ReadKey();
        }
        int ReturnBiggestNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}