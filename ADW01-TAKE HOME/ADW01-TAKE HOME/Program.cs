using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Dealership dealership = new Dealership();
        Console.Write("Add Dealership Name: ");
        string dealershipName = Console.ReadLine();
        Console.Write("Add Dealership Location: ");
        string dealershipLoc = Console.ReadLine();
        bool isTrue = true;
        while (isTrue)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Remove Car");
            Console.WriteLine("3. Print All Car");
            Console.WriteLine("4. Make Sales");
            Console.WriteLine("5. Print Sales");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-----------------");
            Console.Write("Menu Choice: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            Sale sale = new Sale();
            Car car = new Car();
            if (menu == 1)
            {
                Console.WriteLine("1. Hybrid Car");
                Console.WriteLine("2. Electric Car");
                Console.WriteLine("3. Gasoline Car");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                HybridCar hybrid = new HybridCar();
                ElectricCar electric = new ElectricCar();
                GasolineCar gasoline = new GasolineCar();
                if (menu1 == 1)
                {
                    Console.Write("Input Car Make: ");
                    hybrid.Make = Console.ReadLine();
                    Console.Write("Input Car Model: ");
                    hybrid.Model = Console.ReadLine();
                    Console.Write("Input Car Year: ");
                    hybrid.Year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Car Price: ");
                    hybrid.Price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Car GasTankSize: ");
                    hybrid.GasTankSize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Car BatteryCapacity: ");
                    hybrid.BatteryCapacity = Convert.ToInt32(Console.ReadLine());
                    hybrid.Type = "Hybrid";
                    dealership.AddCar(hybrid);
                }
                else if (menu1 == 2)
                {
                    Console.Write("Input Car Make: ");
                    electric.Make = Console.ReadLine();
                    Console.Write("Input Car Model: ");
                    electric.Model = Console.ReadLine();
                    Console.Write("Input Car Year: ");
                    electric.Year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Car Price: ");
                    electric.Price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Car BatteryCapacity: ");
                    electric.BatteryCapacity = Convert.ToInt32(Console.ReadLine());
                    electric.Type = "Electric";
                    dealership.AddCar(electric);
                }
                else if (menu1 == 3)
                {
                    Console.Write("Input Car Make: ");
                    gasoline.Make = Console.ReadLine();
                    Console.Write("Input Car Model: ");
                    gasoline.Model = Console.ReadLine();
                    Console.Write("Input Car Year: ");
                    gasoline.Year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Car Price: ");
                    gasoline.Price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Car GasTankSize: ");
                    gasoline.GasTankSize = Convert.ToInt32(Console.ReadLine());
                    gasoline.Type = "Gasoline";
                    dealership.AddCar(gasoline);
                }
            }
            else if (menu == 2)
            {
                Console.Write("Car make: ");
                string make = Console.ReadLine();
                Console.Write("Car model: ");
                string model = Console.ReadLine();
                dealership.RemoveCar(make,model);
            }
            else if (menu == 3)
            {
                dealership.PrintCars();
            }
            else if (menu == 4)
            {
                Console.Write("Customer Name: ");
                sale.CustomerName = Console.ReadLine();
                Console.Write("Customer Car Make: ");
                sale.CustomerMake = Console.ReadLine();
                Console.Write("Customer Car Model: ");
                sale.CustomerModel = Console.ReadLine();
                Console.Write("Customer Price Paid: ");
                sale.PricePaid = Convert.ToDouble(Console.ReadLine());
                dealership.MakeSale(sale);
                
            }
            else if (menu == 5)
            {
                dealership.PrintSales();
            }
            else
            {
                break;
            }
        }
    }
}

class Car 
{
    private string make;
    private string model;
    private int year;
    private double price;
    private string type;

    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}

class ElectricCar : Car
{
    private int batteryCapacity;

    public int BatteryCapacity
    {
        get { return batteryCapacity; }
        set { batteryCapacity = value; }
    }
}

class HybridCar : Car 
{
    private int gasTankSize;
    private int batteryCapacity;

    public int GasTankSize
    {
        get { return gasTankSize; }
        set { gasTankSize = value; }
    }
    public int BatteryCapacity
    {
        get { return batteryCapacity; }
        set { batteryCapacity = value; }
    }

}

class GasolineCar : Car
{
    private int gasTankSize;
    public int GasTankSize
    {
        get { return gasTankSize; }
        set { gasTankSize = value; }
    }
}

class Dealership
{

    private string name;
    private string location;
    List<Car> Cars = new List<Car>();
    List<Sale> Sales = new List<Sale>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(string carMake, string carModel)
    {
        foreach(Car car in Cars)
        {
            if (car.Make == carMake && car.Model == carModel)
            {
                Cars.Remove(car);
                break;
            }
        }
    }

    public void PrintCars()
    {
        foreach(Car car in Cars)
        {
            Console.WriteLine("Car Make: {0}", car.Make);
            Console.WriteLine("Car Model: {0}", car.Model);
            Console.WriteLine("Car Year: {0}", car.Year);
            Console.WriteLine("Car Price: {0}", car.Price);
            Console.WriteLine("Car Type: {0}", car.Type);
        }
    }

    public void MakeSale(Sale sale)
    {
        foreach (Car a in Cars)
        {
            if (a.Make == sale.CustomerMake && a.Model == sale.CustomerModel)
            {
                Sales.Add(sale);
                Cars.Remove(a);
                break;
            }

        }
    }

    public void PrintSales()
    {
        foreach(Sale sale in Sales)
        {
            Console.WriteLine("Customer Name: {0}", sale.CustomerName);
            Console.WriteLine("Customer Car Make: {0}", sale.CustomerMake);
            Console.WriteLine("Customer Car Model: {0}", sale.CustomerModel);
            Console.WriteLine("Customer Price Paid: {0}", sale.PricePaid);
        }
    }
}

class Sale
{
    private string customerName;
    private string customerModel;
    private string customerMake;
    private double pricePaid;

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public string CustomerMake
    {
        get { return customerMake; }
        set { customerMake = value; }
    }

    public string CustomerModel
    {
        get { return customerModel; }
        set { customerModel = value; }
    }

    public double PricePaid
    {
        get { return pricePaid; }
        set { pricePaid = value; }
    }

}


