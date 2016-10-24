using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemySin:Enemy
	{

		public EnemySin ()
		{
			Sprite = SwinGame.LoadBitmapNamed ("sprite","Sheep.bmp");
		}


		public override void Draw() 
		{
			SwinGame.DrawBitmap ("sprite", X, Y);
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

