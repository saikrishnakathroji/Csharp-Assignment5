/*3)	Write a console based program to create a linked list of Employee objects using the generic class List<>.Perform following operations on the list:
a.	Add a new employee
b.	Display the list of employees.
c.	Total number of employees in the list
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Empcollection
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("sai krishna");
            list.Add("sai kiran");
            list.Add("Sai");
            list.Add("sai kumar");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}
