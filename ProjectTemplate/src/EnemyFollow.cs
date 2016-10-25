using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemyFollow:Enemy
	{
		private Vector _dir;
		private float _hyp;
		public EnemyFollow ()
		{
			Sprite = SwinGame.LoadBitmapNamed ("sprite2","Pig.png");
		}

		public override void Draw() 
		{
			SwinGame.DrawBitmap ("sprite2", X, Y);
			//SwinGame.FillRectangle(Color.Gold, X, Y, Size, Size);

		}




		public override void Move()
		{
			if (Close == false)
			{
				if (Orientation == true)
					X += Speed;
				else
					X -= Speed;
			}
			else
			{
				//enemy follow function
				_dir.X = pl.X - X;
				_dir.Y = pl.Y - Y;
				_hyp = SwinGame.PointPointDistance (SwinGame.PointAt (pl.X, pl.Y), SwinGame.PointAt (X, Y));
				_dir.X /= _hyp;
				_dir.Y /= _hyp;
				X += Convert.ToInt32((_dir.X * Speed));
				Y += Convert.ToInt32((_dir.Y * Speed));


			}

		}




	}
}

