using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class Menu
    {
        public string Title { get; set; }
        public List<string> MenuOptions { get; set; }

        public string ShowMenu()
        {
            Console.WriteLine($"-------------------------- {Title} --------------------------");
            foreach (string option in MenuOptions)
            {
                Console.WriteLine($"");
            }
            return "";
        }
    }
}
