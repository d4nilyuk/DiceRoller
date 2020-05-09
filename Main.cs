using System;
using SplashKitSDK;

namespace DiceRoller
{

    public class Program
    {
        public static void Main()
        {
            //Replace with your path
            string filePath = "/Users/kiryadanilyuk/Desktop/UNI/DP1 SWE20001/P Tasks/DiceRoller/DiceRoller.txt";
            Window mainWindow;
            DiceRoller dice = new DiceRoller();
            mainWindow = new Window("Dice Roller", 800, 600);

            while (!SplashKit.WindowCloseRequested(mainWindow))
            {
                SplashKit.ProcessEvents();
                mainWindow.Clear(Color.White);

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                { 
                    dice.Roll();
                }
                if (SplashKit.KeyTyped(KeyCode.SKey)) {
                    dice.Save(filePath);
                }
                
                dice.Draw(mainWindow);
                mainWindow.Refresh();
            }

        }
    }

}