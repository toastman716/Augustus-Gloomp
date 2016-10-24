using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Game
	{
        
        private int _tempScore = 0;
		private Player _player;
        private Bitmap _playerSprite;
        private Bitmap _enemySprite;
        private int _score;
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
                SwinGame.DrawText ("Score: " + _score, Color.Black, 200, 0);

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

        //collision detection for enemies and players
        public void Collision ()
        {

            Point2D playerpt = SwinGame.PointAt (Player.X, Player.Y);
            _playerSprite = new Bitmap ("sprite");
            _enemySprite = new Bitmap ("sprite");



            List<Enemy> toRemove = new List<Enemy> ();
            foreach (Enemy e in _enemies) {
                Point2D enemypt = SwinGame.PointAt (e.X, e.Y);


                if (SwinGame.BitmapCollision (_playerSprite, playerpt, _enemySprite, enemypt) == true) {
                    if (_player.Size < e.Size) {
                        gameover = true;
                    } else if ((e.X < 3) || (e.X > (SwinGame.ScreenWidth () - 3))) {
                        _tempScore += 1;
                        _player.Size += e.Size;
                        toRemove.Add (e);
                    }

                }
            }
                foreach (Enemy e in toRemove) {
                    _enemies.Remove (e);
                }

                _score = _tempScore;


        }

        public int Score {
            get {
                return _score;
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
