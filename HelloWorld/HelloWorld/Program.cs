using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.BL;
using System.Configuration;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic _objBL = new BusinessLogic();
            

            Console.Write(_objBL.DisplayHelloWorld());
        }
    }
}
