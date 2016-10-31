using NUnit.Framework;
using SwinGameSDK;
namespace MyGame
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void TestCollision ()
        {
            Game gm = new Game ();
            Player bob = new Player ();
            Enemy jeff = new EnemyFollow ();
            bob.X = 5;
            bob.Y = 5;
            jeff.X = 5;
            jeff.Y = 5;
            jeff.Size = 20;
         

            gm.Collision ();
            Assert.IsTrue (gm.gameover == 1);

        }

        [Test]
        public void TestScore ()
        {
            Game gm = new Game ();

            Player bob = new Player ();
            Enemy jeff = new EnemyStraight ();
            bob.X = 5;
            bob.Y = 5;
            jeff.X = 5;
            jeff.Y = 5;
            jeff.Size = 5;
          
            gm.Collision ();

            Assert.IsTrue (gm.Score == 0);
        }

        [Test]
        public void TestSprite ()
        {
            Player bob = new Player ();
            Assert.IsTrue (bob.Sprite == SwinGame.BitmapNamed ("charmander3.png"));
        }

        [Test]
        public void TestGameOver ()
        {
            Game gm = new Game ();

            Player bob = new Player ();
            Enemy jeff = new EnemyFollow ();
            bob.X = 5;
            bob.Y = 5;
            jeff.X = 5;
            jeff.Y = 5;
            jeff.Size = 25;
           
            gm.Collision ();
            Assert.IsTrue (gm.gameover == 1);
        }

    }
}

