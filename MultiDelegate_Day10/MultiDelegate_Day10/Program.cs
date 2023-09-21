using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate_Day10
{
    class Sample
    {
        static void CallMe()
        {
            Console.WriteLine("I am a static Function");
        }
        static void Main()
        {
            Sample s = new Sample();
            s.CallMe();
            /* call the CallMe function*/

            Console.Read();
        }
    }
}




//has context menu
//Compose