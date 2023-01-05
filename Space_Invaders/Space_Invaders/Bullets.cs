/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// Class Bullets : classe qui a les listes des bullets et les methodes de les afficher
/// et des methodes pour verifier les colisions de ces bullets

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Invaders
{
    public class Bullets
    {
        /// <summary>
        /// Liste de bullet
        /// </summary>
        private List<Bullet> _bullets = new List<Bullet>();

        /// <summary>
        /// liste des aliens
        /// </summary>
        private List<Alien> _aliens = new List<Alien>();

        //private Squad Squad = new Squad(10);

        /// <summary>
        /// le scores
        /// </summary>
        private int _scoreAlien ;

        /// <summary>
        /// Getting Setting des scores
        /// </summary>
        public int ScoreAlien { get => _scoreAlien; set => _scoreAlien = value; }
        public List<Bullet> BulletsList { get => _bullets; set => _bullets = value; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Bullets()
        {
            
        }


        /// <summary>
        /// deuxieme constructor avec parametre
        /// </summary>
        public Bullets(List<Bullet> bullets)
        {
            foreach (Bullet bullet in bullets)
            {
                this._bullets.Add(bullet);
            }
        }


        /// <summary>
        /// méthode pour dessiner les bullets
        /// </summary>
        public void DrawBullets()
        {
            
           foreach(Bullet bullet in _bullets)
           {
                bullet.DrawBullet();
           }
        }

        /// <summary>
        /// méthode pour dessiner les bullets des aliens
        /// </summary>
        public void DrawDownBullets()
        {

            foreach (Bullet bullet in _bullets)
            {
                bullet.DrawDownBullet();
            }
        }


        /// <summary>
        /// méthode pour supprimer les bullets
        /// </summary>
        public void DeleteBullets()
        {
            foreach (Bullet bullet in _bullets)
            {
                bullet.DeleteBullet();
            }
        }

        /// <summary>
        /// méthode pour supprimer un bullet
        /// </summary>
        public void DeleteOneBullet()
        {
            foreach (Bullet bullet in _bullets)
            {
                if(bullet.Y == 3)
                {
                    bullet.DeleteBullet();

                }
            }
        }

        /// <summary>
        /// méthode pour déplacer les bullets
        /// </summary>
        public void moveBullets()
        {
            List<Bullet> bullets = new List<Bullet>();
            foreach(Bullet bullet in _bullets)
            {
                if (bullet.Y == 5)
                {
                    bullet.DeleteBullet();
                    bullets.Add(bullet);

                }
                else
                {

                    bullet.MoveBullet();
                }

            }

            foreach(Bullet bullet in bullets)
            {
                _bullets.Remove(bullet);
            }
        }

        /// <summary>
        /// méthode pour ajouter les bullets à la liste
        /// </summary>
        public void AddBullet(int X, int Y)
        {
            _bullets.Add(new Bullet(X, Y));
        }


        /// <summary>
        /// méthode pour ajouter les bullets à la liste avec des parametres
        /// </summary>
        public void AddBullet(int X, int Y, int direction)
        {
            _bullets.Add(new Bullet(X, Y,direction));
        }


        /// <summary>
        /// Méthode pour vérifier le touche des bullets aux Aliens
        /// </summary>
        /// <param name="aliens"> la liste des aliens </param>
        /// <returns> True or False </returns>
        public bool CheckBulletCollision(Squad aliens, List<Wall> wallList)
        {
            List<Alien> _aliens = new List<Alien>();

            List<Bullet> bullets = new List<Bullet>();

            bool _colision = false;

            bool founded = false;
            foreach (Bullet bullet in _bullets)
            {

                foreach (Wall wall in wallList)
                {
                    // Regarde si un mur a eu contact avec un tir et que le mur est encore en vie
                    if ((bullet.X >= wall.X && bullet.X < wall.X + 15) && (bullet.Y -7) <= wall.Y && wall.LifePoints != 0)
                    {

                            Game.DisplayWall(wallList);
                            bullet.DeleteBullet();
                            bullets.Add(bullet);
                            founded = true;
                            break;
                    }
                }

                foreach (Alien alien in aliens.Aliens)
                {

                    if (bullet.X > alien.X && bullet.X < alien.X + 13 && bullet.Y <= alien.Y + 5 && bullet.Y >= alien.Y && _colision == false)
                    {
                        alien.DeleteAlien();
                        _aliens.Add(alien);
                        bullet.DeleteBullet();
                        _scoreAlien += 100;
                        File.WriteAllText("C:/Users/Ahmad/Documents/GitHub/space-invader/Space_Invaders/Space_Invaders/scores.txt", _scoreAlien .ToString());
                        bullets.Add(bullet);
                        _colision = true;
                    }
                }
                

            }
            
            foreach (Alien alien1 in _aliens)
            {
                aliens.Aliens.Remove(alien1);
            }
            foreach (Bullet bullet in bullets)
            {
                _bullets.Remove(bullet);
            }
            return _colision;
        }

        /// <summary>
        /// Methode pour retourner le scores
        /// </summary>
        /// <returns></returns>
        public int Get_theScore()
        {
            return ScoreAlien;
        }

        /// <summary>
        /// Methode qui fait la verification de colision (si les aliens touche le canon)
        /// </summary>
        /// <param name="ship"> le Canon </param>
        /// <returns> True or False </returns>
        public bool CheckAliensBulletsColision(Canon ship, List<Wall> wallList)
        {
            bool _colisionCanon = false;

            List<Bullet> bullets = new List<Bullet>();

            foreach (Bullet bullet in _bullets)
            {
                if(bullet.Y >= 47)
                {
                    bullet.DeleteBullet();
                    bullets.Add(bullet);
                }

                if (bullet.X >= ship.X && bullet.X < ship.X + 5 && bullet.Y <= ship.Y + 3 && bullet.Y >= ship.Y)
                {
                   
                    bullet.DeleteBullet();
                    bullets.Add(bullet);
                    _colisionCanon = true;
                }
                bool founded = false;
                foreach (Wall wall in wallList)
                {
                    // Regarde si un mur a eu contact avec un tir et que le mur est encore en vie
                    if ((bullet.X >= wall.X && bullet.X < wall.X + 15) && wall.Y == bullet.Y && wall.LifePoints != 0)
                    {

                        // Regarde si le tir vient du joueur ou de l'ennemi
                        if (bullet._direction < 0)
                        {
                            wall.LifePoints--;
                            Game.DisplayWall(wallList);
                            _bullets.Remove(bullet);
                            founded = true;
                            break;
                        }
                        else
                        {
                            Game.DisplayWall(wallList);
                            _bullets.Remove(bullet);
                            founded = true;
                            break;
                        }
                    }
                }
                if (founded)
                {
                    founded = false;
                    break;
                }


            }
            foreach (Bullet bullet in bullets)
            {
                _bullets.Remove(bullet);
            }
            return _colisionCanon;



        }



    }
}
