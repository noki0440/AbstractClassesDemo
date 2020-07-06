using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // DONECreate a list of Vehicle called vehicles

            /*
             * DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * DONE Set the properties with object initializer syntax
             */

            /*
             * DONE Add the 4 vehicles to the list
             * DONE Using a foreach loop iterate over each of the properties
             */

            // DONE Call each of the drive methods for one car and one motorcycle

            var vehicles = new List<Vehicle>();

            var Xterra = new Car() { HasHatchBack = true, Make = "Nissan", Model = "Xterra", Year = 2011 };
            Car Accord = new Car() { HasHatchBack = false, Make = "Honda", Model = "Accord", Year = 2000 };
            var Motorcycle = new Motorcycle() { Make = "Kawasaki", Model = "Ninja", Year = 2006 };
            Car ForRunner = new Car() { HasHatchBack = true, Make = "Toyota", Model = "ForRunner", Year = 2016 };
            Vehicle SantaFe = new Car() { HasHatchBack = true, Make = "Hyundai", Model = "Santa Fe", Year = 2015 };

            vehicles.Add(Xterra);
            vehicles.Add(Accord);
            vehicles.Add(ForRunner);
            vehicles.Add(SantaFe);
            vehicles.Add(Motorcycle);

            foreach (var motor in vehicles)
            {
                Console.WriteLine($"Make: {motor.Make} Model: {motor.Model} Year: {motor.Year}");
                motor.DriveVirtual();
                Console.WriteLine("---------------------------------------------------------");
            }


            #endregion            
            Console.ReadLine();
        }
    }
}
