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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(play);
            Console.WriteLine(SON);
            Console.WriteLine(DIFFICULTE);
            Console.WriteLine(SCORES);
            Console.WriteLine(EXIT);
        }



        



    }
}
