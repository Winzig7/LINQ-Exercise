using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{   public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "Call Of Duty", "Halo", "Destiny" };
            videoGames.Sort((x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine(videoGames);
            
        }
    }
}
