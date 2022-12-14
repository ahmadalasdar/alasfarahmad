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


        public void Verify()
        {
            foreach(Bullet bullet in _bullets)
            {
                foreach (Alien alien in _aliens)
                {
                    if (bullet.Y == alien.Y)
                    {
                        bullet.DeleteBullet();
                        alien.DeleteAlien();
                    }
            }
            }
        }

    }
}
