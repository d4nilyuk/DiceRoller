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
        private int _diceValue = 1;

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
            _width = 300;
            _height = 300;
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
        public void Draw(Window currentWindow)
        {
            int[][] displayVal = faceConfig[_diceValue - 1];
            double _circleX = _x+30, _circleY = _y+10, _circleRadius = 30;

            currentWindow.FillRectangle(_color, _x, _y, _width, _height);
            for (int i = 0; i < 3; i++)
            {
                //Initialise coordinate for circle
                _circleY += 50;
                for (int j = 0; j < 3; j++)
                {
                    if (displayVal[i][j] == 1)
                    {
                        currentWindow.FillCircle(Color.White, _circleX, _circleY, _circleRadius);
                    }
                    else
                    {
                        //Move the y Coordinate
                        _circleX += 50;
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