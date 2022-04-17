/*6)Create a class named Player that contains Player name, runs scored as data members.
 * Create a class named Team that contains an array of Player. 
 * Implement IEnumerable interface for class Team.
 * Write a console based application to create an object named India.
 * Use foreach loop to iterate through the object India to display information about its players.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Project5
{
    class Player
    {
        public string Player_name { get; set; }
        public int runs_scored { get; set; }
        public Player(string p,int r)
        {
            this.Player_name = p;
            this.runs_scored = r;
        }

     }

     class Team
     {
        static void Main(string[] args)
        {
            List<Player> India = new List<Player>();
            Player p1 = new Player("Dhoni",60);
            Player p2 = new Player("Sachin",100);
            Player p3 = new Player("virat",90);
            India.Add(p1);
            India.Add(p2);
            India.Add(p3);
            IEnumerable<Player> GetAllPlayers()
            {
                return India;
            }

            foreach (Player p in GetAllPlayers()) // Iterating returned elements  
            {
                Console.WriteLine(p.Player_name + " " +p.runs_scored);
            }
        }
    }
}
