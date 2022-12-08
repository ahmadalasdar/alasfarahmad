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
        /// 
        /// </summary>
        private List<Bullet> _bullets = new List<Bullet>();




        public Bullets()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        public Bullets(List<Bullet> bullets)
        {
            foreach (Bullet bullet in bullets)
            {
                this._bullets.Add(bullet);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void DrawBullets()
        {
           foreach(Bullet bullet in _bullets)
           {
                bullet.DrawBullet();
           }
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteBullets()
        {
            foreach (Bullet bullet in _bullets)
            {
                bullet.DeleteBullet();
            }
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public void AddBullet(int X, int Y)
        {
            _bullets.Add(new Bullet(X, Y));
        }




    }
}
