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
        private Color _color;
        private float _x, _y;
        private int _width, _height;

         public DiceRollerInJava()
         {
            _color = Color.Aqua;
             _x = 0;
             _y = 0;
             _width = 100;
            _height = 100;
         }
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }



        int[][][] faceConfig = new int[][][]
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
                if (input.Equals("no"))
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
            //SplashKit.FillRectangle(White, 100, );
            
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
