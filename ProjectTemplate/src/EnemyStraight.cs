using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemyStraight:Enemy
	{
		public EnemyStraight ()
		{
			Sprite = SwinGame.LoadBitmapNamed ("sprite1","Goat.png");
		}

		public override void Draw() 
		{
            SwinGame.FillCircle (Color.Blue, (X + (SwinGame.BitmapWidth (Sprite) / 2)), (Y + (SwinGame.BitmapHeight (Sprite) / 2)), Size / 2);
			SwinGame.DrawBitmap ("sprite1", X, Y);
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

