using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class MenuOption
    {
        /// <summary>
        /// Default constroctor
        /// </summary>
        public MenuOption()
        {

        }

        /// <summary>
        /// des variables (attributs)
        /// play
        /// son
        /// difficulté
        /// scores
        /// exit?
        /// </summary>
        private const string play = @"     

                                                     _ __  _        _  _ 
                                                    | '_ \| | __ _ | || |
                                                    | .__/| |/ _` | \_. |
                                                    |_|   |_|\__/_| |__/            
        ";

        private const string SON = @" 
                                                     ___ ___  _ _  
                                                    (_-// _ \| ' \ 
                                                    /__/\___/|_||_|           
        ";

        private const string DIFFICULTE = @"
                                                        _  _   __   __  _            _  _   
                                                     __| |(_) / _| / _|(_) __  _  _ | || |_ 
                                                    / _` || ||  _||  _|| |/ _|| || || ||  _|
                                                    \__/_||_||_|  |_|  |_|\__| \_._||_| \__|           
        ";

        private const string SCORES = @"          

                                                     ___ __  ___  _ _  ___  ___
                                                    (_-// _|/ _ \| '_|/ -_)(_-/
                                                    /__/\__|\___/|_|  \___|/__/        
        ";

        private const string EXIT = @"
                                                               _  _     ___    
                                                     ___ __ __(_)| |_  |__ \   
                                                    / -_)\ \ /| ||  _|   /_/   
                                                    \___|/_\_\|_| \__|  (_)              
        ";

        private const string EASY = @"
                                                      __            _  _      
                                                     / _| __ _  __ (_)| | ___ 
                                                    |  _|/ _` |/ _|| || |/ -_)
                                                    |_|  \__/_|\__||_||_|\___|
           
        ";

        private const string HARD = @"
                                                     ___   _   __   __  _      _  _      
                                                    |   \ (_) / _| / _|(_) __ (_)| | ___ 
                                                    | |) || ||  _||  _|| |/ _|| || |/ -_)
                                                    |___/ |_||_|  |_|  |_|\__||_||_|\___|
            
        ";


        public int cursorY = 10;                // Position de Y pour le cursor 
        public int cursorX = 35;                // Position de X pour le cursor




        /// <summary>
        /// methode qui affiche le titre
        /// </summary>
        public void TheTitle()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("");
            Console.WriteLine(@"     _______ ______        __        ______ _________     _____ ____  _____ ____   ____   __      ________   _________ _______     _______ ");
            Console.WriteLine(@"    /  ___  |_   __ \     /  \     ./ ___  |_   ___  |   |_   _|_   \|_   _|_  _| |_  _| /  \    |_   ___ \.|_   ___  |_   __ \   /  ___  |");
            Console.WriteLine(@"   |  (__ \_| | |__) |   / /\ \   / ./   \_| | |_  \_|     | |   |   \ | |   \ \   / /  / /\ \     | |   \. \ | |_  \_| | |__) | |  (__ \_|");
            Console.WriteLine(@"    '.___\-.  |  ___/   / ____ \  | |        |  _|  _      | |   | |\ \| |    \ \ / /  / ____ \    | |    | | |  _|  _  |  __ /   '.___\-.");
            Console.WriteLine(@"   |\\____) |_| |_    _/ /    \ \_\ \.___.'\_| |___/ |    _| |_ _| |_\   |_    \ ' / _/ /    \ \_ _| |___.' /_| |___/ |_| |  \ \_|\\____) |");
            Console.WriteLine(@"   |_______.'_____|  |____|  |____|\._____.'_________|   |_____|_____|\____|    \_/ |____|  |____|________.'|_________|____| |___|_______.'");  

        }

        /// <summary>
        /// methode qui affiche le menu principale
        /// </summary>
        public void PrancipalMenu()
        {
            int i = 0;
            Console.Clear();
            TheTitle();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(play);
            Console.WriteLine(SON);
            Console.WriteLine(DIFFICULTE);
            Console.WriteLine(SCORES);
            Console.WriteLine(EXIT);

            // switch qui s'occupe de ce que l'utilisateur a choisi du Menu
            switch (Deplacement(i))
            {
                case 1:
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    MenuDifficult();
                    break;

                case 4:
                    Console.Clear();
                    Console.Write(SCORES);
                    break;

                case 5:

                    Environment.Exit(0);

                    break;

            }


        }

        /// <summary>
        /// methode qui fait le deplacement
        /// </summary>
        /// <param name="i"></param>
        /// <returns> la valeur de choisir </returns>
        public int Deplacement(int i)
        {

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("==>");

            while (true)
            {

                ConsoleKeyInfo theKey = Console.ReadKey(true);

                // si on tape sur la flèche de bas
                if(theKey.Key == ConsoleKey.DownArrow)
                {
                    // si y est plus que 32 on bloque
                    if(cursorY > 32)
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                    // sinon on descend
                    else
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("   ");
                        cursorY += 6;
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                }

                // si on tape sur la flèche de haut
                if (theKey.Key == ConsoleKey.UpArrow)
                {
                    // si y est moins que 11 on bloque
                    if (cursorY < 11)
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                    // sinon on monte
                    else
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("   ");
                        cursorY -= 6;
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                }

                // si on tape sur Enter et on retune des valeurs

                if(theKey.Key == ConsoleKey.Enter && cursorY == 10)
                {
                    i = 1;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 16)
                {
                    i = 2;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 22)
                {
                    i = 3;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 28)
                {
                    i = 4;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 34)
                {
                    i = 5;
                    return i;
                }




            }

        }

        public void MenuDifficult()
        {
            Console.Clear();
            Console.WriteLine(DIFFICULTE);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(EASY);
            Console.WriteLine(HARD);

            int Y = 10;                // Position de Y pour le cursor de Sous-Menu
            int X = 35;                // Position de X pour le cursor de Sous-Menu
            Console.SetCursorPosition(X, Y);
            Console.Write("==>");

            while (true)
            {

                ConsoleKeyInfo theKey = Console.ReadKey(true);

                // si on tape sur la flèche de bas
                if (theKey.Key == ConsoleKey.DownArrow)
                {
                    // si y est plus que 10 on bloque
                    if (Y > 10)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on descend
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y += 7;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }

                // si on tape sur la flèche de haut
                if (theKey.Key == ConsoleKey.UpArrow)
                {
                    // si y est moins que 11 on bloque
                    if (Y < 11)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on monte
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y -= 7;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }


            }



        }



    }
}
