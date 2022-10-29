using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{

    public class Game
    {
        public int Year { get; set; }
        public string GameTitle { get; set; }
    }  
    

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Game> myList = new List<Game>();

            
            myList.Add(new Game() { GameTitle = "Алиса", Year = 2009 });
            myList.Add(new Game() { GameTitle = "Гиблые земли", Year = 2011 });
            myList.Add(new Game() { GameTitle = "Симс 4", Year = 2014 });
            

            Game game = new Game() { GameTitle = "Фантазмат", Year = 2010 };
            myList.Insert(3, game);
            
            
            for (int i = 0; i < myList.Count; i++)
            {
                Game item = myList[i];
                Console.WriteLine("Название=" + item.GameTitle + " ,Год=" + item.Year);
            }
        }
    }
}


