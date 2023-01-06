/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// class Program principale

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(145, 40);

            MenuOption theGame = new MenuOption();


            // Commencer cette application

            theGame.PrancipalMenu();
            Console.ReadLine();


        }
    }
}
