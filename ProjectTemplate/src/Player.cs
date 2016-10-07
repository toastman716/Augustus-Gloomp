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

	}
}
