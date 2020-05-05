using System;
using SplashKitSDK;

namespace DiceRoller
{

    public class Program
    {
        public static void Main()
        {
            Window mainWindow;
            DiceRoller dice = new DiceRoller();
            mainWindow = new Window("Dice Roller", 800, 600);

            while(!SplashKit.WindowCloseRequested(mainWindow))
            {

                SplashKit.ProcessEvents();
                mainWindow.Clear(Color.White);

                if(SplashKit.KeyTyped(KeyCode.SpaceKey))
                    dice.Roll();
                dice.Draw(mainWindow);
                mainWindow.Refresh();
            }

        }
    }

}
