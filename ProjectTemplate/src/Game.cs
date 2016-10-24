using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Game
	{
		private Player _player;
		private List<Enemy> _enemies = new List<Enemy>(); 
		public bool gameover = false;
		public Game ()
		{
			_player = new Player();

		}

		//draw the game interface
		public void DrawGame()
		{
			_player.Draw ();
			foreach (Enemy e in _enemies)
			{

				e.Draw ();
				//handle the follow enemy requirements
				if ((e is EnemyFollow) && (SwinGame.PointPointDistance (SwinGame.PointAt (_player.X, _player.Y), SwinGame.PointAt (e.X, e.Y)) < 80))
				{

					e.SetPlayer (_player);
					e.Close = true;

				}
				else
					e.Close = false;

				e.Move ();

			}

		}
		//spawn new enemies 
		public void Spawn()
		{
			Random random = new Random ();
			int randtype = random.Next (1,16);

			if (randtype < 10)
			{
				EnemyStraight estr = new EnemyStraight ();
				_enemies.Add (estr);
			}
			else if (randtype>=10&&randtype<=14)
			{
				EnemySin esin = new EnemySin ();
				_enemies.Add (esin);
			}
			else 
			{
				EnemyFollow ef = new EnemyFollow ();
				_enemies.Add (ef);
			}

		}
			

		public Player Player
		{
			get{
				return _player;
			}
			set{
				_player = value;
			}
		}
	}
}
