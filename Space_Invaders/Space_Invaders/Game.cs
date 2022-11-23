using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public const int MIN_X = 0;
        public const int MAX_X = 145; 


        public void AffichageTitre()
        {

        }



        /// <summary>
        /// 
        /// </summary>
        public void StartGame()
        {
            Canon _ship = new Canon(cursorX, cursorY);
            while (true)
            {
                // UPDATE
                DeplacementShip(_ship);



                // Render
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

                _ship.DrawCanon();


            }

            Console.ReadLine();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ship"></param>
        public void DeplacementShip(Canon _ship)
        {

            ConsoleKeyInfo theKey = Console.ReadKey(true);

            // si on tape sur la flèche droite
            if (theKey.Key == ConsoleKey.RightArrow)
            {
                // si X est plus que 60 on bloque
                if (_ship.X < MAX_X - 6)
                {
                    _ship.X += 2;

                }
                // sinon on va à droite
            }

            // si on tape sur la flèche de gauche
            if (theKey.Key == ConsoleKey.LeftArrow)
            {
                // si X est moins que 11 on bloque
                if (_ship.X > MIN_X + 1)
                {
                    _ship.X -= 2;
                }
                // sinon on monte
            }

        }

    }
}
