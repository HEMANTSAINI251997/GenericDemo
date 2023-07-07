using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    public class Generic<T>
    {
        public T data;
        //public Generic(T data)
        //{
        //    this.data = data;
        //    Console.WriteLine("This is Generic data = " + this.data);

        //}
        public void Check(T num)
        {
            Console.WriteLine(""+num);
        }
    }
    public class Demo
    {
        public void checkdemo<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
