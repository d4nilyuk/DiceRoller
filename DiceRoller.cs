using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SplashKitSDK;

namespace diceroll
{
    public class DiceRollerInJava
    {

        int[,,] faceConfig = new int[6, 3, 3]
                           { { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } },
                           { { 0, 0, 1 }, { 0, 0, 0 }, { 1, 0, 0 } },
                           { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 } },
                           { { 1, 0, 1 }, { 0, 0, 0 }, { 1, 0, 1 } },
                           { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } },
                           { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 } } };

        public static void main(String[] args)
        {
            Console.ReadLine();
            DiceRollerInJava dice = new DiceRollerInJava();
            while (true)
            {
                int result = dice.roll();
                Console.WriteLine("dice face value:" + result);
                dice.draw(result);

                Console.WriteLine("Roll again? (type no to quit):");
                string input = Console.ReadLine();
                if ( input.Equals("no"))
                {
                    Console.WriteLine("Bye!");
                    return;
                }
            }
        }

        // Draw the dice face using ascii characters
        private void draw(int value)
        {
            int[,] displayVal = new int[faceConfig[value - 1]] ; 

            Console.WriteLine("-----");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("|");
                for (int j = 0; j < 3; j++)
                {
                    if (displayVal[i,j] == 1)
                    {
                        Console.WriteLine("o");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-----");

        }

        // Roll the dice in Java
        private int roll()
        {
            var rand = new Random();
            return rand.Next(6) + 1;
        }
    }
}