using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
     public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string EngineNoise;
        public string HonkNoise;
        public string IsDrivable;

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}");
        }
        
    }
}
