using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            Car car1 = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = "2020" };
            Motorcycle motorcycle1 = new Motorcycle() { HasSideCart = false, Make = "Honda", Model = "Gold Wing", Year = "1979"};
            Vehicle vehicle1 = new Car() { HasTrunk = true, Make = "Honda", Model = "Accord", Year = "2000" };
            Vehicle vehicle2 = new Motorcycle() { HasSideCart = true, Make = "Triumph", Model = "Rocket 3", Year = "2006" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Type of Vehicle.: {vehicle.GetType().Name}");
                Console.WriteLine($"Year of Vehicle.: {vehicle.Year}");
                Console.WriteLine($"Make of Vehicle.: {vehicle.Make}");
                Console.WriteLine($"Model of Vehicle: {vehicle.Model}\n\n");
            }

            // Call each of the drive methods for one car and one motorcycle

            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine("\n\n");
            vehicle2.DriveAbstract();
            vehicle2.DriveVirtual();

            #endregion            
            //Console.ReadLine();
        }
    }
}
