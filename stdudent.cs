/*4)	Write Custom Generic class MyStack based on assignment of previous session, with
Push() and Pop() methods to store any kind of .NET Type. 
*/
using System.Collections;
namespace Project5
{
    internal class stdudent
    {
            static void Main()
            {
                Stack stack1 = new Stack();
                stack1.Push(1);
                stack1.Push("Employee");
                stack1.Push(57.8);
                stack1.Push("sai krishna");
                foreach (Object obj in stack1)
                {
                    Console.WriteLine("different types of data" + ":" + obj);
                }
                stack1.Pop();
                stack1.Pop();
                foreach (Object obj in stack1)
                {
                    Console.WriteLine("after pop operation" + ":" + obj);
                }

                Console.ReadLine();
            }
        
    }
}
