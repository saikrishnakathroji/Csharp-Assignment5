/*7)	Use an iterator to iterate through the players in the 6th example.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Project5
{
    class Players
    {
        public string Player_name { get; set; }
        public int runs_scored { get; set; }
        public Players(string p, int r)
        {
            this.Player_name = p;
            this.runs_scored = r;
        }

    }

    class Teams
    {
        static void Main(string[] args)
        {
            ArrayList India = new ArrayList();
            Player p1 = new Player("Dhoni", 50);
            Player p2 = new Player("Sachin", 100);
            Player p3 = new Player("virat", 90);
            India.Add(p1);
            India.Add(p2);
            India.Add(p3);
            foreach (Player p in India) // Iterating returned elements  
            {
                Console.WriteLine(p.Player_name + " " + p.runs_scored);
            }
        }
    }
}