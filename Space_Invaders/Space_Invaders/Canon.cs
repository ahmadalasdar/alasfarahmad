using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Canon
    {

        private int _x;                                                // variable position x du canon
        private int _y;                                                // variable position y du canon 
        private static string[] _symbol = new string[3]                // tableau du symbole
        {
            "  █  ",
            "█████",
            "█████"
        };

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Canon(int X, int Y)
        {
            _x = X;
            _y = Y;
        }


        /// <summary>
        /// getting setting la position x
        /// </summary>
        public int X
        { get { return _x; }
          set { _x = value; } 
        }

        /// <summary>
        /// getting setting la position y
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// getting le symbole du canon
        /// </summary>
        public string[] Symbol
        {
            get { return _symbol; }
        }
    }
}
