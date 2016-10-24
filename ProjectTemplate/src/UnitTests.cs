using System;
using NUnit.Framework;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	[TestFixture]
	public class UnitTests
	{
		[Test]
		public void TestCollision()
		{
            Player bob = new Player ();
            Enemy Jeff = new EnemySin ();
            bob.X = 5;
            bob.Y = 5;
            Jeff.X = 5;
            Jeff.Y = 5;
            Point2D _playerpt = SwinGame.PointAt (bob.X, bob.Y);
            Point2D _enmypt = SwinGame.PointAt (Jeff.X, Jeff.Y);
            Bitmap _playerSprite = new Bitmap ("sprite");
            Bitmap _enemySprite = new Bitmap ("sprite");
            Assert.IsTrue (SwinGame.BitmapCollision (_playerSprite, _playerpt, _enemySprite, _enmypt));


		}

		[Test]
		public void TestScore()
		{
            Game gm = new Game ();
            Player bob = new Player ();
            Enemy Jeff = new EnemySin ();
            bob.X = 5;
            bob.Y = 5;
            Jeff.X = 5;
            Jeff.Y = 5;
            Jeff.Size = 5;
            Point2D _playerpt = SwinGame.PointAt (bob.X, bob.Y);
            Point2D _enmypt = SwinGame.PointAt (Jeff.X, Jeff.Y);
            Bitmap _playerSprite = new Bitmap ("sprite");
            Bitmap _enemySprite = new Bitmap ("sprite");
            SwinGame.BitmapCollision (_playerSprite, _playerpt, _enemySprite, _enmypt);
            Assert.IsTrue (gm.Score == 4);
            
		}

	}
}

