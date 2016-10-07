using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemyStraight:Enemy
	{
		public EnemyStraight ()
		{
			Sprite = "Chocolate.bmp";
		}

		public override void Draw() 
		{
			SwinGame.DrawBitmap (Sprite, X, Y);
			//SwinGame.FillRectangle(Color.Red, X, Y, Size, Size);
		}


		public override void Move()
		{
			if (Orientation == true)
				X += Speed;
			else
				X -= Speed;
		}
	}
}

