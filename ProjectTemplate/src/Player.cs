using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Player:Entity
	{

		public Player ()
		{
			Size = 15;
			Sprite = SwinGame.LoadBitmapNamed ("sprite", "charmander3.png");

		}

		public override void Draw() 
		{
			SwinGame.DrawBitmap ("sprite", X, Y);
			//SwinGame.FillCircle(Color.Blue, X, Y, Size/2);
		}

        public void Move ()
        {
            if (SwinGame.KeyDown (KeyCode.vk_DOWN) && Y < (SwinGame.ScreenHeight () - Size)) {
                Y += 1;
            }

            if (SwinGame.KeyDown (KeyCode.vk_UP) && Y > Size + 0) {
                Y -= 1;
            }

			if (SwinGame.KeyDown (KeyCode.vk_RIGHT) && X < (SwinGame.ScreenWidth() - Size)) {
                X += 1;
            }

            if (SwinGame.KeyDown (KeyCode.vk_LEFT) && X > Size + 0 ) {
                X -= 1;
            }
        }

	}
}
