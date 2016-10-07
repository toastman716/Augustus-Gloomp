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
			Sprite = "Fatty.bmp";
		}

		public override void Draw() 
		{
			SwinGame.DrawBitmap (Sprite, X, Y);
			//SwinGame.FillCircle(Color.Blue, X, Y, Size/2);
		}

        public void Move ()
        {
            if (SwinGame.KeyDown (KeyCode.vk_DOWN) && Y < (SwinGame.ScreenHeight () - Size)) 
            {
                Y += Y;
            }

            if (SwinGame.KeyDown (KeyCode.vk_UP) && Y > Size + 0) 
            {
                Y -= Y;
            }
            if (SwinGame.KeyDown (KeyCode.vk_LEFT) && Y < (SwinGame.ScreenWidth () - Size)) 
            {
                Y += Y;
            }

            if (SwinGame.KeyDown (KeyCode.vk_RIGHT) && X > Size + 0) 
            {
                Y -= Y;
            }
        }

	}
}
