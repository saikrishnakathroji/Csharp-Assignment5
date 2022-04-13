using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Employee(int eid, string ename)
        {
            this.EmpId = eid;
            this.EmpName = ename;
        }
    }
    internal class Programs
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            ArrayList e = new ArrayList();//non generic
            List<Employee> eg = new List<Employee>();
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
