using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Shoot
    {

        private char _symbol = '|';     // Le symbol du tire

        private int _y;                 // La position Y du Shoot
        private int _x;


        /// <summary>
        /// liste qui contient les bullets
        /// </summary>
        private List<Shoot> _listBullets = new List<Shoot>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Shoot(int X, int Y)
        {
            _y = Y;
            _x = X;
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
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public char Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

    }
}
