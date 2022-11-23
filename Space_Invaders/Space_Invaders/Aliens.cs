using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Aliens
    {
        /// <summary>
        /// 
        /// </summary>
        private int _y;

        /// <summary>
        /// 
        /// </summary>
        private int _x;


        /// <summary>
        /// 
        /// </summary>
        private static string[] _symbol = new string[5]                // tableau du symbole
        {
               "  ▀▄   ▄▀  ",
               " ▄█▀███▀█▄ ",
               "█▀███████▀█",
               "█░█▀▀▀▀▀█░█",
               "   ▀▀░▀▀   "
        };

        /// <summary>
        /// 
        /// </summary>
        private static string[] _noSymbol = new string[5]                // tableau du symbole
        {
               "           ",
               "           ",
               "           ",
               "           ",
               "           "
        };

        /// <summary>
        /// Default constroctor
        /// </summary>
        public Aliens(int X, int Y)
        {
            _x = X;
            _y = Y;
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

        
    }
}
