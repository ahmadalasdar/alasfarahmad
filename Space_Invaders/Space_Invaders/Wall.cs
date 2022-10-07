using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Wall
    {
        private int _life = 2;          // La vie du Wall

        /// <summary>
        /// Get Set de la variable life
        /// </summary>
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }




    }
}
