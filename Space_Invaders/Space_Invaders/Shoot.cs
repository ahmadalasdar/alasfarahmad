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

        /// <summary>
        /// Default constroctor
        /// </summary>
        public Shoot()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }



    }
}
