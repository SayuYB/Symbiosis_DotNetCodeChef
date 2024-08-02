using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class Vehicle
    {
        public void vehicleShow()
        {
            Console.WriteLine("This is Vehicle!");
        }

        //Common method in Vehicle and suv
        public void display()
        {
            Console.WriteLine("This is a car-Vehicle");
        }
    }
    // Vehicle -> Two_Wheeler
    internal class Two_Wheeler : Vehicle
    {
        public void twoWheelerShow() 
        {
            Console.WriteLine("This is Two Wheeler!");
        }
    }

    //Vehicle -> four wheeler -> car -> suv
    internal class Four_Wheeler : Vehicle
    {
        public void fourWheelerShow()
        {
            Console.WriteLine("This is Four Wheeler!");
        }
    }
    internal class Car: Four_Wheeler
    {
        public void carShow()
        {
            Console.WriteLine("This is Car!");
        }
    }
    internal class Suv : Car
    {
        public void suvShow()
        {
            Console.WriteLine("This is SUV!");
        }
       
        //Common method in Vehicle and suv
        public void display()
        {
            Console.WriteLine("This is a car-SUV");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.display();
            Suv suv = new Suv();
            suv.display();
        }
    }
}
