using System;
using System.Reflection.Metadata;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public DVD(string name, string discType, double capacity, double maxReadSpeed, double maxWriteSpeed, string discContents) :
           base(name, discType, capacity, maxReadSpeed, maxWriteSpeed, discContents)
        { }

            public void SpinDisc()
            {
                Console.WriteLine("A DVD spins at about 1530 RPM at the inside edge and 630 RPM at the outside edge");
            }

            public void ReadData()
            {
                foreach (string item in Content)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------\n");
                }
            }

    }
}
