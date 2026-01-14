using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    
    internal class Program
{
        class car
        {
            //public string colour;
            //public string name;
            //public int numofcar;
            private string colour;
            private string name;
            private int numofcar;
            public void runningcar()
            {
                Console.WriteLine("I can run the car\n");
            }
            public bool IsopenDoor()
            {
                return true;
            }

            public void IncreaseSpeed()
            {
                Console.WriteLine("I can Increase speed car\n");
            }


            public void printInfo()
            {
                Console.WriteLine(colour);
                Console.WriteLine(name);
                Console.WriteLine(numofcar);

            }
            public void insertInfo(string c,string n,int nc)
            {
                colour = c;
                name = n;
                numofcar = nc;
            }
        }
        static void Main(string[] args)
        {
            car c1 = new car();
            c1.insertInfo("red","BMW",1234);
            c1.printInfo();
            //c1.colour="Red";
            //c1.numofcar = 1234;
            //c1.name = "BMW";
            //c1.printInfo();
            //Console.WriteLine("______________________________");
            //car c2 = new car();
            //c1.colour = "blue";
            //c1.numofcar = 4321;
            //c1.name = "Toyota";
            //c1.printInfo();

        }
    }
}
