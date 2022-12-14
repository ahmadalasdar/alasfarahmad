using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Bullets
    {
        /// <summary>
        /// Liste de bullet
        /// </summary>
        private List<Bullet> _bullets = new List<Bullet>();

        private List<Alien> _aliens = new List<Alien>();

        private Squad Squad = new Squad(10);

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
        /// 
        /// </summary>
        /// <param name="squad"></param>
        public void CheckBulletCollision(Squad aliens)
        {
            List<Alien> _aliens = new List<Alien>();

            foreach (Bullet bullet in _bullets)
            {
                foreach (Alien alien in aliens.Aliens)
                {

                    if (bullet.X > alien.X && bullet.X < alien.X + 15 && bullet.Y <= alien.Y + 10 && bullet.Y >= alien.Y)
                    {
                        alien.DeleteAlien();
                        _aliens.Add(alien);
                        //squad.Aliens.Remove(alien);
                        bullet.DeleteBullet();
                    }
                }
            }

            foreach (Alien alien1 in _aliens)
            {
                aliens.Aliens.Remove(alien1);
            }

        }





    }
}
