﻿using System;
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
            Console.CursorVisible = true;
            Console.SetWindowSize(145, 40);

            MenuOption test = new MenuOption();


            // tester le titre et le menu

            test.PrancipalMenu();
            Console.ReadLine();


        }
    }
}
