using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Nov
{
    class Car
    {
        public int Year { get; set; }
        public int PalletNo { get; set; }
        public double Price { get; set; }
        public string carMake { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }
        public Car(int year, int palletNo, double price, string carMake, string type, string model, string color)
        {
            Year = year;
            PalletNo = palletNo;
            Price = price;
            this.carMake = carMake;
            Type = type;
            Model = model;
            Color = color;
        }

        public  void start()
        {
            Console.WriteLine("The engine of car is start ");
        }
        public  void stop()
        {
            Console.WriteLine("The engine of car is stop ");
        }
        public void print()
        {
            Console.WriteLine($"The Year of car {Year} , the model {Model}, type {Type} , car make {carMake} , pallet number of car {PalletNo} , price {Price} , color {Color} ");
        }
    }

    class Mercdes:Car
    {
        public Mercdes(int year, int palletNo, double price, string carMake, string type, string model, string color) : base ( year,  palletNo,  price,  carMake,  type,  model,  color)
        {

        }

        public void litterPerKilo(int lit)
        {
            int distance=lit*20;
            Console.WriteLine($"The distance of{lit} = {distance}");

        }
    }
    internal class Test
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the year of car");
            int year=Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the pallet number of car");
            int palletNo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the price of car");
            double price = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("Enter the car Make of car");
            string carMake = Console.ReadLine();

            Console.WriteLine("Enter the type of car");
            string type =  Console.ReadLine();

            Console.WriteLine("Enter the model of car");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the color of car");
            string color = Console.ReadLine();

            Car myCar=new Car(year,palletNo, price, carMake,type,model,color);
            myCar.start();
            myCar.stop();
            myCar.print();


            Console.WriteLine("Enter the litter ");
            int liter =Convert.ToInt32 (Console.ReadLine());

            Mercdes car = new Mercdes(year, palletNo, price, carMake, type, model, color);
            car.litterPerKilo(liter);



        }
    }
}
