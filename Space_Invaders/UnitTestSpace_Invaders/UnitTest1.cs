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

            Wall test2 = new Wall();


            test2.Life--;



            //Assert

            Assert.AreEqual(1, test2.Life);

        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestIfTheShootToucheTheAlien()
        {
            //Act
            Aliens firestAlien = new Aliens();

            Shoot shipBullet = new Shoot();

            shipBullet.Y += 10;


            //Assert
            Assert.AreEqual(shipBullet.Y, firestAlien.Y);

        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void TestIfTheCanonWasHit()
        {

            Canon myCanon = new Canon();
            Shoot alienBullet = new Shoot();

            alienBullet.Y += 5;

            Assert.AreEqual(alienBullet.Y,myCanon);
        }





    }
}
