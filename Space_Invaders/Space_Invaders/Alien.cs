using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Alien
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
        public Alien(int X, int Y)
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



        public void DrawAlien()
        {
            for (int i = 0; i < _symbol.Length; i++)
            {

                for (int g = 0; g < _symbol[i].Length; g++)
                {
                    Console.SetCursorPosition(X + g, Y + i);
                    Console.WriteLine(_symbol[i][g]);
                }
            }
        }


        /// <summary>
        /// Delelte Canon
        /// </summary>
        public void DeleteAlien()
        {
            for (int i = 0; i < _noSymbol.Length; i++)
            {

                for (int g = 0; g < _noSymbol[i].Length; g++)
                {
                    Console.SetCursorPosition(X + g, Y + i);
                    Console.WriteLine(_noSymbol[i][g]);
                }
            }
        }

    }
}
