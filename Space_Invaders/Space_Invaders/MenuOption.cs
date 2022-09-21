using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class MenuOption
    {

        public MenuOption()
        {

        }


        private const string play = @"     


                         _ __  _        _  _ 
                        | '_ \| | __ _ | || |
                        | .__/| |/ _` | \_. |
                        |_|   |_|\__/_| |__/            
        ";

        private const string son = @" 
                         ___ ___  _ _  
                        (_-// _ \| ' \ 
                        /__/\___/|_||_|           
        ";

        private const string difficult = @"
                            _  _   __   __  _            _  _   
                         __| |(_) / _| / _|(_) __  _  _ | || |_ 
                        / _` || ||  _||  _|| |/ _|| || || ||  _|
                        \__/_||_||_|  |_|  |_|\__| \_._||_| \__|           
        ";

        private const string scores = @"                                         
                         ___ __  ___  _ _  ___  ___
                        (_-// _|/ _ \| '_|/ -_)(_-/
                        /__/\__|\___/|_|  \___|/__/        
        ";

        private const string exit = @"
                                   _  _     ___    
                         ___ __ __(_)| |_  |__ \   
                        / -_)\ \ /| ||  _|   /_/   
                        \___|/_\_\|_| \__|  (_)              
        ";


        public void TheTitre()
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

        public void PrancipalMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(play);
            Console.WriteLine(son);
            Console.WriteLine(difficult);
            Console.WriteLine(scores);
            Console.WriteLine(exit);
        }
        



    }
}
