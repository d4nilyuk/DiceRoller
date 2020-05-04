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

        int [][][] faceConfig = new int [][][]
            {
                new int [][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } },
                new int [][] { new int[] { 0, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 0 } },
                new int [][] { new int[] { 0, 0, 1 }, new int[] { 0, 1, 0 }, new int[] { 1, 0, 0 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 0, 1, 0 }, new int[] { 1, 0, 1 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 0, 1 } }



            };
        public static void Main(String[] args)
        {
            Console.ReadLine();
            DiceRollerInJava dice = new DiceRollerInJava();
            while (true)
            {
                int result = dice.Roll();
                Console.WriteLine("dice face value:" + result);
                dice.Draw(result);

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
        private void Draw(int value)
        {
            int[][] displayVal = faceConfig[value - 1];
            Console.WriteLine("-----");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    if (displayVal[i][j] == 1)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-----");

        }

        // Roll the dice in Java
        private int Roll()
        {
            var rand = new Random();
            return rand.Next(6) + 1;
        }
    }
}