using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main ()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow ("GameMain", 800, 600);
            Game game = new Game ();
            game.Player.X = (50);
            game.Player.Y = (50);
            int x = 0;
            //Run the game loop
            while (false == SwinGame.WindowCloseRequested ()) {
                SwinGame.ClearScreen (Color.White);
                SwinGame.DrawFramerate (0, 0);
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents ();
                game.DrawGame ();
                game.Collision ();
                game.GameOver ();

                //Clear the screen and draw the framerate


                //Draw onto the screen
                SwinGame.RefreshScreen (60);
                x++;
                if (x == 20) {
                    x = 0;
                    game.Spawn ();
                }

                if (SwinGame.KeyTyped (KeyCode.vk_SPACE))
                    Pause ();
            }


        }


        public static void Pause ()
        {
            while (false == SwinGame.WindowCloseRequested ()) {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents ();
                if (SwinGame.KeyTyped (KeyCode.vk_SPACE))
                    break;

            }
        }




    }
}