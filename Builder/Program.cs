namespace CarBuilder;

class Program
{
    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public string? Engine { get; set; }
        public string? TripComputer { get; set; }
        public bool GPS { get; set; }


        public override string ToString() =>
            $@"
Make {Make}
Model {Model}
Year {Year}
Seats {Seats}
Engine {Engine}
TripComputer {TripComputer}
GPS {GPS}";
    }
    
    interface IBuilderCars
    {
        Car Car { get; set; }
        void Reset();
        Car Build();

        IBuilderCars SetMake(string make);
        IBuilderCars SetModel(string model);
        IBuilderCars SetYear(int year);
        IBuilderCars SetSeats(int number);
        IBuilderCars SetEngine(string engine);
        IBuilderCars SetTripComputer(string com);
        IBuilderCars SetGPS();
    }

    class CarBuilder : IBuilderCars
    {
        public Car Car { get; set; } = new Car();

        public void Reset() => Car = new Car();

        public IBuilderCars SetEngine(string engine)
        {
            Car.Engine = engine;
            return this;
        }

        public IBuilderCars SetGPS()
        {
            Car.GPS = true;
            return this;
        }

        public IBuilderCars SetMake(string make)
        {
            Car.Make = make;
            return this;
        }

        public IBuilderCars SetModel(string model)
        {
            Car.Model = model;
            return this;
        }

        public IBuilderCars SetSeats(int number)
        {
            Car.Seats = number;
            return this;
        }

        public IBuilderCars SetTripComputer(string com)
        {
            Car.TripComputer = com;
            return this;
        }

        public IBuilderCars SetYear(int year)
        {
            Car.Year = year;
            return this;
        }

        public Car GetResult()
        {
            return Car;
        }

        public Car Build() => Car;
    }

    class CarManualBuilder : IBuilderCars
    {
        public Car Car { get; set; } = new Car();

        public void Reset() => Car = new Car();

        public IBuilderCars SetEngine(string engine)
        {
            Car.Engine = engine;
            return this;
        }

        public IBuilderCars SetGPS()
        {
            Car.GPS = true;
            return this;
        }

        public IBuilderCars SetMake(string make)
        {
            Car.Make = make;
            return this;
        }

        public IBuilderCars SetModel(string model)
        {
            Car.Model = model;
            return this;
        }

        public IBuilderCars SetSeats(int number)
        {
            Car.Seats = number;
            return this;
        }

        public IBuilderCars SetTripComputer(string com)
        {
            Car.TripComputer = com;
            return this;
        }

        public IBuilderCars SetYear(int year)
        {
            Car.Year = year;
            return this;
        }

        public Car GetResult()
        {
            return Car;
        }

        public Car Build() => Car;
    }


    class Director
    {
        public void MakeSportsCar(IBuilderCars builder)
        {
            builder.Reset();
            builder.SetMake("Bmw");
            builder.SetModel("X5");
            builder.SetYear(2002);
            builder.SetSeats(4);
            builder.SetEngine("Engine");
            builder.SetTripComputer("TripComputer");
            builder.SetGPS();
        }
    }

    static void Main(string[] args)
    {
        //Director director = new Director();
        //CarBuilder builder = new CarBuilder();
        //director.MakeSportsCar(builder);
        //Car car = builder.GetResult();
        //Console.WriteLine(car);

        ////////////////////////////////////////////////////////

        //IBuilderCars builderCars = new CarManualBuilder();
        //Car manual = builderCars
        //    .SetMake("Bmw")
        //    .SetModel("X5")
        //    .SetSeats(4)
        //    .Build();
        //Console.WriteLine(manual);

        ////////////////////////////////////////////////////////

        IBuilderCars builderCars = new CarBuilder();
        Car car = builderCars
            .SetMake("Bmw")
            .SetModel("X5")
            .SetSeats(4)
            .Build();
        Console.WriteLine(car);

    }
}