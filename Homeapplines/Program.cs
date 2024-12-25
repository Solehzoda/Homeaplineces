using System;

namespace Homeapplines
{
    class Program
    {
        private string brand;
        protected int power;
        public bool isON;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public void TurnON()
        {
            isON = true;
            Console.WriteLine("Turned ON");
        }

        public void TurnOFF()
        {
            isON = false;
            Console.WriteLine("Turned OFF");
        }

        public void InfoDisplay()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("On off: " + isON);
        
    }

        class Refrigirator : Program
        {
            public Refrigirator(string brand, int power)
            {
                this.Brand = brand;
                this.power = power;
                this.isON = false;
            }
        }

        public void RefrigiratorDisplay()
        {
            Console.WriteLine("InfoRefrigirator");
            
        }

        class WashingMachine: Program
        {
            public WashingMachine(string brand, int power)
            {
                this.Brand = brand;
                this.power = power;
                this.isON = false;
            }

            public void InfoWashingMachineDisplay()
            {
                Console.WriteLine("InfoWashingMachine");
            }
        }
        static void Main(string[] args)
        {
           Refrigirator refrigirator = new Refrigirator("Samsung", 220);
           WashingMachine washingMachine = new WashingMachine("LG", 110);
           
           refrigirator.RefrigiratorDisplay();
           refrigirator.TurnON();
           refrigirator.TurnOFF();
           
           Console.WriteLine(refrigirator.Brand);
           
           
           washingMachine.InfoWashingMachineDisplay();
           washingMachine.isON = true;
           washingMachine.InfoDisplay();
           washingMachine.isON = false;
           washingMachine.InfoWashingMachineDisplay();
           
           
        }
    }
}