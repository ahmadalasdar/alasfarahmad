/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// Class Bullet : classe qui a des methode de bullet avec les symboles et les methodes
/// de dessin des bullet de canon et des aliens

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
        /// le symbol de bullet du canon
        /// </summary>
        private static char[] _symbol = new char[2]                // tableau du symbole
        {       '|',
                ' '
        };


        /// <summary>
        /// le symbol de bullet pour les aliens
        /// </summary>
        private static char[] _downSymbol = new char[2]                // tableau du symbole
        {       ' ',
                '|'
        };


        /// <summary>
        /// 
        /// </summary>
        private static char[] _noSymbol = new char[2]                // tableau du symbole
        {       ' ',
                ' '
        };

        /// <summary>
        /// La position Y du Shoot
        /// </summary>
        private int _y;

        /// <summary>
        /// La position X du Shoot
        /// </summary>
        private int _x;

        /// <summary>
        /// la direction
        /// </summary>
        public int _direction = 1;

        /// <summary>
        /// Constrocteur 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Bullet(int X, int Y)
        {
            _y = Y;
            _x = X;
        }

        /// <summary>
        ///  deuxieme constrocteur
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Bullet(int X, int Y, int direction)
        {
            _y = Y;
            _x = X;
            _direction = direction;
        }

        /// <summary>
        /// Getting Setting de la position Y du Shoot
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Getting Setting de la position X du Shoot
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Getting Setting du symbol
        /// </summary>
        public char[] Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// Methode qui fait dessiner le bullet
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
        /// Methode qui fait supprimer le bullet
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
        /// Methode qui fait bouger le bullet
        /// </summary>
        public void MoveBullet()
        {
            Y = Y - _direction;
        }


        /// <summary>
        /// Methode qui fait dessiner le bullet des aliens
        /// </summary>
        public void DrawDownBullet()
        {
            for (int i = 0; i < _downSymbol.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(_downSymbol[i]);
            }
        }
    }
}
