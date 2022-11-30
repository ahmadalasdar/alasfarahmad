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
        /// 
        /// </summary>
        public string name { get; set; }
        public int cursorX = 65;
        public int cursorY = 46;

        private Canon _ship;

        public const int MIN_X = 0;
        public const int MAX_X = 145;
        private const string PAUSE = @"

                                            ███████╗███╗   ██╗    ██████╗  █████╗ ██╗   ██╗███████╗███████╗
                                            ██╔════╝████╗  ██║    ██╔══██╗██╔══██╗██║   ██║██╔════╝██╔════╝
                                            █████╗  ██╔██╗ ██║    ██████╔╝███████║██║   ██║███████╗█████╗  
                                            ██╔══╝  ██║╚██╗██║    ██╔═══╝ ██╔══██║██║   ██║╚════██║██╔══╝  
                                            ███████╗██║ ╚████║    ██║     ██║  ██║╚██████╔╝███████║███████╗
                                            ╚══════╝╚═╝  ╚═══╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝
                                                               
        ";


        /// <summary>
        /// 
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
            Console.WriteLine("Life : " + "♥♥♥");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
        }



        /// <summary>
        /// 
        /// </summary>
        public void StartGame()
        {

            _ship = new Canon(cursorX, cursorY);
            // Render
            DrawBoard();

            _ship.DrawCanon();

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
                    }




                }


            }

            Console.ReadLine();
        }


        /// <summary>
        /// 
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

        }

    }
}
