using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            
        }
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle Drive Abstract Override");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorocyle Drive Virtual Override");
        }

    }
}
