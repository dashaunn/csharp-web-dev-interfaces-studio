using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public CD(string name, string discType, double capacity, double maxReadSpeed, double maxWriteSpeed, string discContents) :
           base (name, discType, capacity, maxReadSpeed, maxWriteSpeed, discContents){ }

            public void SpinDisc()
            {
            Console.WriteLine("A CD spins at about 500 RPM at the inside edge and 200 RPM at the outside edge");
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
