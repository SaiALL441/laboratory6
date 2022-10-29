using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new ComedyDeveloper("Comedy");
            Game game = dev.Create();
            dev = new HorrorDeveloper("Horror");
            Game game2 = dev.Create();
            Console.ReadLine();
        }
    }
    
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string k)
        {
            Name = k;
        }
        abstract public Game Create();
    }
    
    class HorrorDeveloper:Developer
    {
        public HorrorDeveloper(string k) 
            : base(k)
        { 
        }

        public override Game Create()
        {
            return new HorrorGame();
        }
    }
    
    class ComedyDeveloper : Developer
    {
        public ComedyDeveloper(string k) 
            : base(k)
        { 
        }

        public override Game Create()
        {
            return new ComedyGame();
        }
    }

    abstract class Game
    { 
    }

    class HorrorGame:Game
    {
        public HorrorGame()
        {
            Console.WriteLine("Play horror");
        }
    }
    class ComedyGame:Game
    {
        public ComedyGame()
        {
            Console.WriteLine("Play comedy");
        }
    }
}
