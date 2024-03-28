using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilApp.Data
{
    public class SoilTest
    {
        public int moistureLevel { get; set; }
        public double pHValue { get; set; }
        public double nitrogenValue { get; set; }
        public double phosphorusValue { get; set; }
        public double potassiumValue { get; set; }
        public long timestamp { get; set; }

        // Constructor for initializing a new instance of SoilTestData
        public SoilTest(int moisture, double pHVal, double nitrogenVal, double phosphorusVal, double potassiumVal, long time_stamp)
        {
            moistureLevel = moisture;
            pHValue = pHVal;
            nitrogenValue = nitrogenVal;
            phosphorusValue = phosphorusVal;
            potassiumValue = potassiumVal;
            timestamp = time_stamp;
        }

        public SoilTest() { }
    }
}
