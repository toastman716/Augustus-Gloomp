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
			Sprite = SwinGame.LoadBitmapNamed ("sprite", "p1.png");

		}

		public override void Draw() 
		{
			SwinGame.DrawBitmap ("sprite", X, Y);
			//SwinGame.FillCircle(Color.Blue, X, Y, Size/2);
		}

//        public override void Move ()
//        {
//            if (SwinGame.KeyDown (KeyCode.vk_DOWN) && Y < (SwinGame.ScreenHeight () - Size)) {
//                Y += Y;
//            }
//
//            if (SwinGame.KeyDown (KeyCode.vk_UP) && Y > Size + 0) {
//                Y -= Y;
//            }
//
//            if (SwinGame.KeyDown (KeyCode.vk_RIGHT) && Y < (SwinGame.ScreenWidth () - Size)) {
//                X += X;
//            }
//
//            if (SwinGame.KeyDown (KeyCode.vk_LEFT) && Y > Size + 0) {
//                X -= X;
//            }
//        }

	}
}
