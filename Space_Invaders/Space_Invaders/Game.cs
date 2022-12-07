using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Space_Invaders
{
    public class Game
    {
        /// <summary>
        /// Getting et Setting le nom du joueur
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// les vie de Canon (player)
        /// </summary>
        public byte playerHearts = 3;

        /// <summary>
        /// la position X du cursor
        /// </summary>
        public int cursorX = 65;

        /// <summary>
        /// la position Y du cursor
        /// </summary>
        public int cursorY = 46;

        /// <summary>
        /// Counter
        /// </summary>
        public int _counter = 0;

        /// <summary>
        /// le canon
        /// </summary>
        private Canon _ship;

        /// <summary>
        /// la liste des aliens
        /// </summary>
        private Squad _aliens = new Squad(10);

        /// <summary>
        /// la Constate minimume de X
        /// </summary>
        public const int MIN_X = 0;

        /// <summary>
        /// la Constate maximum de X
        /// </summary>
        public const int MAX_X = 145;

        /// <summary>
        /// liste qui contient les bullets
        /// </summary>
        private List<Shoot> _listBullets = new List<Shoot>();

        /// <summary>
        /// le nombre des bllets
        /// </summary>
        private int _numberOfBullet = 0;

        /// <summary>
        /// le nombre max des bullets
        /// </summary>
        private const int NUMBEROFBULLETMAX = 30;

        /// <summary>
        /// 
        /// </summary>
        private double _freezeShoot = 500;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _freezeBullet;

        /// <summary>
        /// le temps de bullet tiré
        /// </summary>
        private DateTime _shootTime;

        /// <summary>
        /// Constate de string (En pause)
        /// </summary>
        private const string PAUSE = @"

                                            ███████╗███╗   ██╗    ██████╗  █████╗ ██╗   ██╗███████╗███████╗
                                            ██╔════╝████╗  ██║    ██╔══██╗██╔══██╗██║   ██║██╔════╝██╔════╝
                                            █████╗  ██╔██╗ ██║    ██████╔╝███████║██║   ██║███████╗█████╗  
                                            ██╔══╝  ██║╚██╗██║    ██╔═══╝ ██╔══██║██║   ██║╚════██║██╔══╝  
                                            ███████╗██║ ╚████║    ██║     ██║  ██║╚██████╔╝███████║███████╗
                                            ╚══════╝╚═╝  ╚═══╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝
                                                               
        ";

        /// <summary>
        /// le niveau du jeu
        /// </summary>
        public int level = 1;

        /// <summary>
        /// méthoder pour afficher le board
        /// </summary>
        private void DrawBoard()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Score : ");
            Console.WriteLine("Level : ");
            Console.SetCursorPosition(120, 2);
            Console.WriteLine("Name : " + name);
            Console.SetCursorPosition(120, 3);
            DysplayHearts(playerHearts);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
        }



        /// <summary>
        /// méthode pour commencer le jeu
        /// </summary>
        public void StartGame()
        {

            _ship = new Canon(cursorX, cursorY);
            // Render
            DrawBoard();

            _ship.DrawCanon();
            _aliens.DrawAliens();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo theKey = Console.ReadKey(true);

                    // UPDATE
                    switch (theKey.Key)
                    {
                        case ConsoleKey.RightArrow:
                            DeplacementShip(_ship, theKey.Key);
                            break;

                        case ConsoleKey.LeftArrow:
                            DeplacementShip(_ship, theKey.Key);
                            break;

                        case ConsoleKey.Spacebar:
                            Pause(_ship);
                            break;
                        case ConsoleKey.UpArrow:
                            if ((DateTime.Now - _freezeBullet).TotalMilliseconds >= 35)
                            {
                                ClearBullet();
                                MooveBullet();
                                DrawBullet();
                                _freezeBullet = DateTime.Now;
                            }
                            if ((DateTime.Now - _shootTime).TotalMilliseconds >= _freezeShoot)
                            {
                                _listBullets.Add(new Shoot(_ship.X + 2, _ship.Y - 1));
                                if (_numberOfBullet <= NUMBEROFBULLETMAX)
                                    _numberOfBullet++;
                                _shootTime = DateTime.Now;
                            }
                            break;
                    }




                }

                if (_counter++ % 5 == 0)
                {
                    _aliens.DeplacementAliens();
                }
                Thread.Sleep(10);


            }

            Console.ReadLine();
        }


        /// <summary>
        /// méthode qui fait le déplacement de Canon
        /// </summary>
        /// <param name="_ship"></param>
        public void DeplacementShip(Canon _ship, ConsoleKey theKey)
        {

            // si on tape sur la flèche droite
            if (theKey == ConsoleKey.RightArrow)
            {

                // si X est plus que 60 on bloque
                if (_ship.X < MAX_X - 6)
                {
                    _ship.DeleteCanon();
                    _ship.X += 2;
                    _ship.DrawCanon();

                }
                // sinon on va à droite
            }

            // si on tape sur la flèche de gauche
            if (theKey == ConsoleKey.LeftArrow)
            {
                // si X est moins que 11 on bloque
                if (_ship.X > MIN_X + 1)
                {
                    _ship.DeleteCanon();
                    _ship.X -= 2;
                    _ship.DrawCanon();
                }
                // sinon on monte
            }

        }


        /// <summary>
        /// méthode qui met le jeu en pause
        /// </summary>
        public void Pause(Canon _ship)
        {
            ConsoleKeyInfo theKey;
            Console.Clear();
            Console.WriteLine(PAUSE);
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t  Retaper sur SpaceBar si vous voulez Continuer...!");

            do
            {
                theKey = Console.ReadKey(true);



            } while (theKey.Key != ConsoleKey.Spacebar);

            Console.Clear();
            DrawBoard();
            _ship.DrawCanon();
            _aliens.DrawAliens();

        }


        /// <summary>
        /// méthode qui gère les vies de canon (player)
        /// </summary>
        /// <param name="playerHeart"></param>
        public void DysplayHearts(byte playerHeart)
        {
            char heart = '♥';
            string hearts = "";

            for (int i = 0; i < playerHeart; i++)
            {
                hearts += heart;
            }
            Console.SetCursorPosition(120, 3);
            Console.WriteLine("Life : " + hearts);

        }

        /// <summary>
        /// Dessiner les bullets
        /// </summary>
        public void DrawBullet()
        {
            // Boucle pour afficher chaques bullets dans le tableau
            foreach (Shoot bullets in _listBullets)
            {
                if (bullets != null)
                {
                    Console.SetCursorPosition(bullets.X, bullets.Y);
                    Console.Write(bullets.Symbol);
                }
            }

        }

        /// <summary>
        /// Faire le mouvement des bullets 
        /// </summary>
        public void MooveBullet()
        {
            var ActiveBullets = _listBullets;
            // Si la liste n'est pas vide
            if (_listBullets != null)
            {
                // Boucle qui va rechercher toute les bullets du tableau et les déplacer, elle vérifie aussi si elle touche un Invaders
                foreach (Shoot bullets in ActiveBullets)
                {
                    if (bullets.Y >= 8)
                    {
                        bullets.Y--;
                    }

                }
            }

        }

        /// <summary>
        /// supprimer les pullet
        /// </summary>
        public void ClearBullet()
        {
            // Boucle pour effacer chaques bullets dans le tableau
            foreach (Shoot bullets in _listBullets)
            {
                if (bullets != null)
                {
                    Console.SetCursorPosition(bullets.X, bullets.Y);
                    Console.Write(" ");
                }
            }
        }

    }
}
