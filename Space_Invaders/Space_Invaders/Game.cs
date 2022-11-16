using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Game
    {

        public string name { get; set; }


        public void StartGame(){

            Console.Clear();

            Canon _ship = new Canon(30, 46);

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Score : ");
            Console.WriteLine("Level : ");
            Console.SetCursorPosition(120, 2);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");

            _ship.DrawCanon();


            Console.ReadLine();
        }
        




    }
}
