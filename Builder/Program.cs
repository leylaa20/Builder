namespace Builder;

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
    class Manual
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public string? Engine { get; set; }
        public string? TripComputer { get; set; }
        public bool GPS { get; set; }
        public bool Has3Pedals { get; set; }


        public override string ToString() =>
            $@"
Make {Make}
Model {Model}
Year {Year}
Seats {Seats}
Engine {Engine}
TripComputer {TripComputer}
GPS {GPS}
Has3Pedals {Has3Pedals}";
    }

    interface IBuilder
    {
        void Reset();
        IBuilder SetMake(string make);
        IBuilder SetModel(string model);
        IBuilder SetYear(int year);
        IBuilder SetSeats(int number);
        IBuilder SetEngine(string engine);
        IBuilder SetTripComputer(string com);
        IBuilder SetGPS();
    }

    class CarBuilder : IBuilder
    {
        public Car Car { get; set; } = new Car();

        public void Reset() => Car = new Car();

        public IBuilder SetEngine(string engine)
        {
            Car.Engine = engine;
            return this;
        }

        public IBuilder SetGPS()
        {
            Car.GPS = true;
            return this;
        }

        public IBuilder SetMake(string make)
        {
            Car.Make = make;
            return this;
        }

        public IBuilder SetModel(string model)
        {
            Car.Model = model;
            return this;
        }

        public IBuilder SetSeats(int number)
        {
            Car.Seats = number;
            return this;
        }

        public IBuilder SetTripComputer(string com)
        {
            Car.TripComputer = com;
            return this;
        }

        public IBuilder SetYear(int year)
        {
            Car.Year = year;
            return this;
        }

        public Car GetResult()
        {
            return Car;
        }
    }

    class CarManualBuilder : IBuilder
    {
        public Manual Manual { get; set; } = new Manual();

        public void Reset() => Manual = new Manual();

        public IBuilder SetEngine(string engine)
        {
            Manual.Engine = engine;
            return this;
        }

        public IBuilder SetGPS()
        {
            Manual.GPS = true;
            return this;
        }

        public IBuilder SetMake(string make)
        {
            Manual.Make = make;
            return this;
        }

        public IBuilder SetModel(string model)
        {
            Manual.Model = model;
            return this;
        }

        public IBuilder SetSeats(int number)
        {
            Manual.Seats = number;
            return this;
        }

        public IBuilder SetTripComputer(string com)
        {
            Manual.TripComputer = com;
            return this;
        }

        public IBuilder SetYear(int year)
        {
            Manual.Year = year;
            return this;
        }

        public Manual GetResult()
        {
            return Manual;
        }

    }


    class Director
    {
        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetMake("Bmw");
            builder.SetModel("X5");
            builder.SetYear(2002);
            builder.SetSeats(2);
            builder.SetEngine("Sport Engine");
            builder.SetTripComputer("TripComputer");
            builder.SetGPS();
        }
    }

    static void Main(string[] args)
    {
        Director director = new Director();
        CarBuilder builder = new CarBuilder();
        director.MakeSportsCar(builder);
        Car car = builder.GetResult();
        Console.WriteLine(car);
    }
}