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
        /// istancier l'objet des aliens
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
        /// istancier l'objet des bullets
        /// </summary>
        private Bullets _bullets = new Bullets();


        /// <summary>
        /// Constante de string (En pause)
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
                _bullets.DrawBullets();
                _bullets.moveBullets();
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
                            _bullets.AddBullet(_ship.X + 2, _ship.Y-1);
                            _bullets.DrawBullets();
                            _bullets.moveBullets();
                            _ship.DrawCanon();
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
        /// Méthode qui fait le déplacement du canon selon la clé lue
        /// </summary>
        /// <param name="_ship"> Le canon </param>
        /// <param name="theKey"> La clé (Key) </param>
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
        /// <param name="_ship"> Le canon </param>
        public void Pause(Canon _ship)
        {
            ConsoleKeyInfo theKey;
            Console.Clear();
            Console.WriteLine(PAUSE);
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t  Retaper sur SpaceBar si vous voulez Continuer...!");

            // boucle de recommencement (si la clé n'est pas SpaceBar)
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
        /// <param name="playerHeart"> le nombre des coeurs (Hearts) (HP) de player </param>
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

    }
}
