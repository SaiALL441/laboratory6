using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    
    class Program 
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1" , "ko");
            dict.Add("2" , "mao");
            dict.Add("3" , "che");
            dict.Add("4", "tao");
            
              

            dict["5"] = "ri";
            foreach (string key in dict.Keys)
                Console.WriteLine("Ключ: " + key + ", значение=" + dict[key]);
            Console.ReadLine();
        }
    }
}
