using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Aliens
    {
        private int _y;
        private int _x;



        private static string[] _symbol = new string[5]                // tableau du symbole
        {
               "  ▀▄   ▄▀  ",
               " ▄█▀███▀█▄ ",
               "█▀███████▀█",
               "█░█▀▀▀▀▀█░█",
               "   ▀▀░▀▀   "
        };


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
