using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Space_Invaders;


namespace UnitTestSpace_Invaders
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// premier test
        /// </summary>
        [TestMethod]
        public void TestIfMenuIsNotNull()
        {
            //Act

            MenuOption test = new MenuOption();

            //Assert

            Assert.IsNotNull(test);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestTheHealthOfWall()
        {
            //Act

            Wall test2 = new Wall(1,15,30);


            test2.LifePoints --;



            //Assert

            Assert.AreEqual(1, test2.LifePoints);

        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestIfTheShootToucheTheAlien()
        {
            //Act
            Alien firestAlien = new Alien(10,10);

            Bullet shipBullet = new Bullet(50,20);

            shipBullet.Y -= 10;


            //Assert
            Assert.AreEqual(shipBullet.Y, firestAlien.Y);

        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void TestIfTheCanonWasHit()
        {

            Canon myCanon = new Canon(50,30);
            Bullet alienBullet = new Bullet(50,25);

            alienBullet.Y += 5;

            Assert.AreEqual(alienBullet.Y,myCanon.Y);
        }





    }
}
