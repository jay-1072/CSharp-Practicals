using System;

namespace Abstraction
{
    public class Laptop
    {
        private string? brand;
        private string? model;

        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public string Model
        {
            get => model;
            set => model = value;
        }

        public void LaptopDetails()
        {
            Console.WriteLine("\nBrand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }

        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
