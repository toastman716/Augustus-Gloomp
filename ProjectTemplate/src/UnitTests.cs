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
            Enemy jeff = new EnemyFollow ();
            bob.X = 5;
            bob.Y = 5;
            jeff.X = 5;
            jeff.Y = 5;
            Point2D _playerpt = SwinGame.PointAt (bob.X, bob.Y);
            Point2D _enemypt = SwinGame.PointAt (jeff.X, jeff.Y);

           // Assert.IsTrue (SwinGame.BitmapCollision (bob.Sprite, _playerpt, jeff.Sprite, _enemypt));

		}

		[Test]
		public void TestScore()
		{
            Game gm = new Game ();

            Player bob = new Player ();
            Enemy jeff = new EnemyFollow ();
            bob.X = 5;
            bob.Y = 5;
            jeff.X = 5;
            jeff.Y = 5;
            jeff.Size = 5;
            Point2D _playerpt = SwinGame.PointAt (bob.X, bob.Y);
            Point2D _enemypt = SwinGame.PointAt (jeff.X, jeff.Y);
			gm.Collision ();
            //SwinGame.BitmapCollision (bob.Sprite, _playerpt, jeff.Sprite, _enemypt);
            Assert.IsTrue (gm.Score == 0);
		}

		[Test]
		public void TestSprite()
		{
			Player bob = new Player ();
			Assert.IsTrue (bob.Sprite == SwinGame.BitmapNamed("charmander3.png")); 
		}



	}
}

