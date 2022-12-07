using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Squad
    {
        /// <summary>
        /// 
        /// </summary>
        private const int _aliensStartX = 0;
        /// <summary>
        /// 
        /// </summary>
        private const int _aliensStartY = 6;
        /// <summary>
        /// 
        /// </summary>
        private const int _aliensWidth = 14;
        /// <summary>
        /// 
        /// </summary>
        private const int _aliensLingth = 6;

        /// <summary>
        /// 
        /// </summary>
        private int _direction = 1;

        /// <summary>
        /// 
        /// </summary>
        private bool _moveDown =true;

        /// <summary>
        /// 
        /// </summary>
        private List<Alien> _aliens = new List<Alien>();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="aliens"></param>
        public Squad(List<Alien> aliens)
        {
            foreach (Alien alien in aliens)
            {
                this._aliens.Add(alien);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="aliens"></param>
        public Squad(int nomberAliens)
        {
            for(int i = 0; i < nomberAliens/2; i++)
            {
                Alien alien = new Alien(_aliensStartX + (_aliensWidth * i), _aliensStartY);
                Alien alien2 = new Alien(_aliensStartX + (_aliensWidth * i), _aliensStartY + _aliensLingth);
                _aliens.Add(alien);
                _aliens.Add(alien2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DrawAliens()
        {

            foreach(Alien alien in _aliens)
            {
                alien.DrawAlien();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteAliens()
        {

            foreach (Alien alien in _aliens)
            {
                alien.DeleteAlien();
            }

        }

        /// <summary>
        /// Adds X and Y to the current positions of the aliens
        /// Moves the aliens by the given X and Y
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void MoveAliens(int X, int Y)
        {
            foreach(Alien alien in _aliens)
            {
                alien.X = alien.X + X;
                alien.Y = alien.Y + Y;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeplacementAliens()
        {
            
            if(((_aliens[_aliens.Count-1].X + _aliensWidth) == 145) && !_moveDown)
            {
                
                MoveAliens(0, 1);
                _direction = -1;
                _moveDown = true;
            }
            else if((_aliens[0].X == 0) && !_moveDown)
            {
                
                MoveAliens(0, 1);
                _direction = 1;
                _moveDown = true;
            }
            else
            {
                
                MoveAliens(_direction, 0);
                _moveDown = false;
            }
            DrawAliens();


        }












    }
}
