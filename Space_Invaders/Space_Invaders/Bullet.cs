using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Bullet
    {

        /// <summary>
        /// 
        /// </summary>
        private static char[] _symbol = new char[2]                // tableau du symbole
        {       '|',
                ' '
        };


        /// <summary>
        /// 
        /// </summary>
        private static char[] _noSymbol = new char[2]                // tableau du symbole
        {       ' ',
                ' '
        };

        private int _y;                 // La position Y du Shoot
        private int _x;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Bullet(int X, int Y)
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
        public char[] Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DrawBullet()
        {
            for(int i = 0; i < _symbol.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Symbol[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBullet()
        {
            for (int i = 0; i < _noSymbol.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(_noSymbol[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void MoveBullet()
        {
            Y = Y - 1;
        }

    }
}
