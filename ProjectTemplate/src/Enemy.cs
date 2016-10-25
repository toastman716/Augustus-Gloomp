using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public abstract class Enemy:Entity
	{
		private bool _orientation;
		private int _speed;
		private bool _close;
		//set random size, x, y and orientation values for each enemy 
		public Enemy ()
		{
			Random rnd = new Random ();
			int randSize = rnd.Next (1, 10);
			int randX = rnd.Next (0, 100);
			int randY = rnd.Next (0, 600);
			int randSpeed = rnd.Next (1, 5);
			if (randX < 50)
			{
				X = (0 - Size);
				_orientation = true; 
			}
			else
			{
				X = 800;
				_orientation = false;
			}
			Y = randY;
			_speed = randSpeed;
			Size = randSize;
		}

		//function to access the game player to use in enemy follow
		public Player pl;

		public void SetPlayer(Player p)
		{
			pl = p;
		}

		public bool Orientation
		{
			get{
				return _orientation;
			}
		}


		public bool Close
		{
			get{
				return _close;
			}
			set{
				_close = value;
			}
		}
		public int Speed
		{
			get{
				return _speed;
			}
		}

		public abstract void Move ();
	}
}

