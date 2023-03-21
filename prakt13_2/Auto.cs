using System.Collections;
using System.Collections.Generic;
namespace prakt13_2
{
    class Auto
    {
        private string Marka;
        private string Model;
        private string VIN;
        private string Color;
        private int Year;
        public Auto(string Marka, string Model, string VIN, string Color, int Year)
        {
            this.Marka=Marka;
            this.Model = Model;
            this.VIN = VIN;
            this.Color = Color;
            this.Year = Year;
        }
        
        public string getMarka()
        {
            return this.Marka;
        }
        public string getModel()
        {
            return this.Model;
        }
        public string getVIN()
        {
            return VIN;
        }
        public string getColor()
        {
            return this.Color;
        }
        public int getYear()
        {
            return this.Year;
        }
        public void setMarka(string Marka2)
        {
            this.Marka=Marka2;
        }
        public void setModel(string Model2)
        {
            this.Model = Model2;
        }
        public void setVIN(string VIN2)
        {
            this.VIN = VIN2;
        }
        public void setColor(string Color2)
        {
            this.Color = Color2;
        }
        public void setYear(int Year2)
        {
            this.Year = Year2;
        }
    }
}
