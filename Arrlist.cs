/*2)	Use collection class such as ArrayList to hold more than one employee objects in Employee Management application.
 * Display all Employee details which are stored in collection.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project5
{
    class Employ
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Employ(int eid, string ename)
        {
            this.EmpId = eid;
            this.EmpName = ename;
        }
    }
    class Arrlist
    {
        static void Main()
        {
            ArrayList e = new ArrayList();//non generic
            List<Employ> eg = new List<Employ>();
            Employee e1 = new Employee(1, "sai krishna");
            Employee e2 = new Employee(2, "rakesh");
            Employee e3 = new Employee(3, "akhil");
            e.Add(e1);
            e.Add(e2);
            e.Add(e3);
            foreach (Employee i in e)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName);
            }
            Console.ReadKey();
        }
    }
}
