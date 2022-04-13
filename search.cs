/* 5)	In the assignment 3 above, add a functionality to search an employee on name in the List<>.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class search
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("sai krishna");
            list.Add("sai kiran");
            list.Add("sai");
            list.Add("sai kumar");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.WriteLine("enter person name:");
            string X= Console.ReadLine();
            if(list.Contains(X))
            {
                Console.WriteLine("yes " + X +" is an employee" );
            }
            else
            {
                Console.WriteLine("no");
            }


            
            Console.ReadLine();
        }
    }
}
