using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemySin:Enemy
	{

		public EnemySin ()
		{
			Sprite = SwinGame.LoadBitmapNamed ("sprite3","Sheep.png");
		}


		public override void Draw() 
		{
            SwinGame.FillCircle (Color.Blue, (X + (SwinGame.BitmapWidth (Sprite) / 2)), (Y + (SwinGame.BitmapHeight (Sprite)/2)), Size / 2);
			SwinGame.DrawBitmap ("sprite3", X, Y);
			//SwinGame.FillCircle(Color.BlueViolet, X, Y, Size/2);
		}


		public override void Move()
		{
			if (Orientation == true){
				X += Speed;
				Y += Convert.ToInt32(5*Math.Sin (X/10));
			}
			else{
				X -= Speed;
				Y -= Convert.ToInt32(5*Math.Sin (X/10));
			}
		}
	}
}

