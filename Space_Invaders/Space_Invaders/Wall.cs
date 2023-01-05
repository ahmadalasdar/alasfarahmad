using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Wall
    {
        /// <summary>
        /// 
        /// </summary>
        private int _id;

        /// <summary>
        /// 
        /// </summary>
        private int _x;

        /// <summary>
        /// 
        /// </summary>
        private int _y;

        /// <summary>
        /// 
        /// </summary>
        private int _lifePoints = 6;

        /// <summary>
        /// 
        /// </summary>
        private string _symbole = "▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Wall(int id, int x, int y)
        {
            _id = id;
            _x = x;
            _y = y;

        }


        /// <summary>
        /// 
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LifePoints
        {
            get { return _lifePoints; }
            set { _lifePoints = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Symbole
        {
            get { return _symbole; }
            set { _symbole = value; }
        }



    }
}
