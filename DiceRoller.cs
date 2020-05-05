using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SplashKitSDK;

namespace DiceRoller
{
    public class DiceRoller
    {
        private Color _color;
        private double _x, _y, _width, _height;
        private int _diceValue = 0;

        private int [][][] faceConfig = new int [][][]
            {
                new int [][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } },
                new int [][] { new int[] { 0, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 0 } },
                new int [][] { new int[] { 0, 0, 1 }, new int[] { 0, 1, 0 }, new int[] { 1, 0, 0 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 0, 1, 0 }, new int[] { 1, 0, 1 } },
                new int [][] { new int[] { 1, 0, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 0, 1 } }



            };

        public DiceRoller()
        {
            _color = Color.Black;
            _x = 300;
            _y = 200;
            _width = 200;
            _height = 200;
        }
       /*
        * public static void Main(String[] args) {
            Console.ReadLine();
            DiceRoller dice = new DiceRoller();
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
        */
       

        // Draw the dice face using splashkit shapes
        public void Draw()
        {
            int[][] displayVal = faceConfig[_diceValue - 1];
            double _circleX = _x, _circleY = _y, _circleRadius = 50;

            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                //Initialise coordinate for circle
                _circleY += 25;
                for (int j = 0; j < 3; j++)
                {
                    if (displayVal[i][j] == 1)
                    {
                        SplashKit.FillCircle(Color.White, _circleX, _circleY, _circleRadius);
                    }
                    else
                    {
                        //Move the y Coordinate
                        _circleY += 25;
                    }
                }
            }

        }

        public void Roll()
        {
            var rand = new Random();
            _diceValue = rand.Next(6) + 1;
        }
    }
}