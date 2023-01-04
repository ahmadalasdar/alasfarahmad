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

        private List<Alien> _aliens = new List<Alien>();

        //private Squad Squad = new Squad(10);

        private int _scoreAlien ;

        public int ScoreAlien { get => _scoreAlien; set => _scoreAlien = value; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Bullets()
        {
            
        }


        /// <summary>
        /// Constructor
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
        /// méthode pour dessiner les bullets
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
        /// méthode pour supprimer un bullet les bullets
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
        /// méthode pour ajouter les bullets à la liste
        /// </summary>
        public void AddBullet(int X, int Y, int direction)
        {
            _bullets.Add(new Bullet(X, Y,direction));
        }


        /// <summary>
        /// Méthode pour vérifier le touche des bullets aux Aliens
        /// </summary>
        /// <param name="aliens"> la liste des aliens </param>
        public bool CheckBulletCollision(Squad aliens)
        {
            List<Alien> _aliens = new List<Alien>();

            List<Bullet> bullets = new List<Bullet>();

            bool _colision = false;


            foreach (Bullet bullet in _bullets)
            {
                foreach (Alien alien in aliens.Aliens)
                {

                    if (bullet.X > alien.X && bullet.X < alien.X + 13 && bullet.Y <= alien.Y + 5 && bullet.Y >= alien.Y)
                    {
                        alien.DeleteAlien();
                        _aliens.Add(alien);
                        //squad.Aliens.Remove(alien);
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
        /// 
        /// </summary>
        /// <returns></returns>
        public int Get_theScore()
        {
            return ScoreAlien;
        }

        public bool CheckAliensBulletsColision(Canon ship)
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
            }
            foreach (Bullet bullet in bullets)
            {
                _bullets.Remove(bullet);
            }
            return _colisionCanon;



        }



    }
}
