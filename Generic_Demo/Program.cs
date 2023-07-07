using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Generic<int> generic = new Generic<int>(25);
            //Generic<long> genericlong = new Generic<long>(2555555);
            //Generic<float> genericfloat = new Generic<float>(2 / 5);
            //Generic<string> genericstring = new Generic<string>("hello");
            //Generic<char> genericchar = new Generic<char>('a');
            //Generic<double> genericdouble = new Generic<double>(25.2);
            //Generic<bool> genericbool = new Generic<bool>(true);

            Generic<int> objec = new Generic<int>();
            objec.Check(55);

            //generic.Check(25);s
            //genericstring.Check("HEMANT");
            //genericlong.Check(2555555);

            //object of nromal class
            Demo demo = new Demo();
            demo.checkdemo<int>(30);
            demo.checkdemo<string>("SAINI");
        }
    }
}
