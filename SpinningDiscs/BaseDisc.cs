using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public string DiscType { get; }
        public double Capacity { get; }
        public double DataUsed { get; set; } = 0;
        public string DiscContents { get; set; }

        public double MaxReadSpeed { get; }
        public double MaxWriteSpeed { get; }
        public List<string> Content { get; set; }

        public BaseDisc(string name, string discType, double capacity, double maxReadSpeed, double maxWriteSpeed, string discContents)
        {
            Name = name;
            DiscType = discType;
            Capacity = capacity;
            MaxReadSpeed = maxReadSpeed;
            MaxWriteSpeed = maxWriteSpeed;
            DiscContents = discContents;

            
        }

        public void WriteData(double dataSize, List<string> data)
        {
            if(DataUsed + dataSize > Capacity)
            {
                Console.WriteLine("Not enough space leftover");
            } 
            else
            {
                Content = data;
                DataUsed += dataSize;
                Console.WriteLine($"Successful. {dataSize}GB of data written");
            }
        }

        public void ShowProperties()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("DISC INFORMATION");
            Console.WriteLine($"Disc Name: {Name}");
            Console.WriteLine($"Disc Type: {DiscType}");
            Console.WriteLine($"Storage Capacity: {Capacity}GB | Data Used: {DataUsed}GB");
            Console.WriteLine($"Max Read Speed: {MaxReadSpeed}x | Max Write Speed: {MaxWriteSpeed}x");
            Console.WriteLine("-----------------");
        }

        public void CheckRemainingCapacity()
        {
            Console.WriteLine($"Remaining Capacity: {Capacity - DataUsed}GB");
        }

    }
}

