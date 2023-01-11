/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// Class Aliens : Classe qui a des methode des aliens avec des listes des aliens et les methodes
/// pour les afficher et supprimer

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
        /// Position de Start d'aliens X
        /// </summary>
        private const int _aliensStartX = 0;
        /// <summary>
        /// Position de Start d'aliens Y
        /// </summary>
        private const int _aliensStartY = 6;
        /// <summary>
        /// width of aliens
        /// </summary>
        private const int _aliensWidth = 14;
        /// <summary>
        /// Lingth of aliens
        /// </summary>
        private const int _aliensLingth = 6;

        /// <summary>
        /// la direction
        /// </summary>
        private int _direction = 1;

        /// <summary>
        /// boolien qui vérifie quand l'alien déscend
        /// </summary>
        private bool _moveDown =true;

        /// <summary>
        /// Lise des aliens
        /// </summary>
        private List<Alien> _aliens = new List<Alien>();

        

        /// <summary>
        /// Getting List Aliens
        /// </summary>
        public List<Alien> Aliens { get => _aliens; set => _aliens = value; }


        /// <summary>
        /// Random
        /// </summary>
        private Random _random = new Random();


        /// <summary>
        /// istancier objet bullets
        /// </summary>
        private Bullets _bullets = new Bullets();

        public Bullets Bullets { get => _bullets; set => _bullets = value; }

        /// <summary>
        /// Constroctur qui ajoute chaque alien à la liste
        /// </summary>
        /// <param name="aliens"> La liste des aliens </param>
        public Squad(List<Alien> aliens)
        {
            foreach (Alien alien in aliens)
            {
                this._aliens.Add(alien);
            }
        }


        /// <summary>
        /// Constructor avec les nombre paires des aliens
        /// </summary>
        /// <param name="nomberAliens"> Nombre des aliens</param>
        public Squad(int nomberAliens)
        {
            for(int i = 0; i < nomberAliens/2; i++)
            {
                Alien alien = new Alien(_aliensStartX + (_aliensWidth * i), _aliensStartY);
                Alien alien2 = new Alien(_aliensStartX + (_aliensWidth * i), _aliensStartY + _aliensLingth);
                Alien alien3 = new Alien(_aliensStartX + (_aliensWidth * i), _aliensStartY + _aliensLingth * 2);
                _aliens.Add(alien);
                _aliens.Add(alien2);
                _aliens.Add(alien3);
            }
        }

        /// <summary>
        /// méthode pour dessiner tous les aliens de la liste
        /// </summary>
        public void DrawAliens()
        {

            foreach(Alien alien in _aliens)
            {
                alien.DrawAlien();
            }

        }

        /// <summary>
        /// méthode pour supprimer tous les aliens 
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
        /// <param name="X"> Position de X </param>
        /// <param name="Y"> Position de Y </param>
        public void MoveAliens(int X, int Y)
        {
            foreach(Alien alien in _aliens)
            {
                alien.X = alien.X + X;
                alien.Y = alien.Y + Y;
            }
        }

        /// <summary>
        /// méthode pour faire le déplacement de tous les aliens 
        /// </summary>
        public void DeplacementAliens()
        {

            if (_aliens.Count > 0)
            {
                if (((_aliens[_aliens.Count - 1].X + _aliensWidth) == 145) && !_moveDown)
                {

                    MoveAliens(0, 1);
                    _direction = -1;
                    _moveDown = true;
                }
                else if ((_aliens[0].X == 0) && !_moveDown)
                {

                    MoveAliens(0, 1);
                    _direction = 1;
                    _moveDown = true;
                }
                else if(_aliens[_aliens.Count() -1].Y + _aliensLingth == 35)
                {
                    Game.DysplayInfosIfHeroIsDied();
                }
                else
                {

                    MoveAliens(_direction, 0);
                    _moveDown = false;
                }
                DrawAliens();
            }


        }


        /// <summary>
        /// Supprimer l'alien de la liste
        /// </summary>
        public void RemoveAliens()
        {
            foreach(Alien alien in _aliens)
            {
                _aliens.Remove(alien);
            }
        }

        public void ShootAliens()
        {
            int _numberAliens = _aliens.Count();

            int _shootingAlienPosition = _random.Next(_numberAliens);

            Alien shootingAlien = _aliens[_shootingAlienPosition];

            _bullets.AddBullet(shootingAlien.X + _aliensWidth / 2, shootingAlien.Y + _aliensLingth,-1);
        }


    }
}
