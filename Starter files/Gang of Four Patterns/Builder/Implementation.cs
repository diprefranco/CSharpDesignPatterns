﻿using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// Product
    /// </summary>
    public class Car
    {
        /// <summary>
        /// _parts can be a List of classes (engine, frame, etc).
        /// </summary>
        private readonly List<string> _parts = new();
        private readonly string _carType;

        public Car(string carType)
        {
            _carType = carType;
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in _parts)
            {
                sb.Append($"Car of type {_carType} has part {part}. ");
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// Builder. It's the abstract base class for concrete builders.
    /// </summary>
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }

    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class MiniBuilder : CarBuilder
    {
        public MiniBuilder() : base("Mini")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'3-door with stripes'");
        }
    }

    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metallic finish'");
        }
    }

    /// <summary>
    /// Director
    /// </summary>
    public class Garage
    {
        private CarBuilder? _builder;

        public Garage()
        {
        }

        public void Construct(CarBuilder builder)
        {
            _builder = builder;

            _builder.BuildEngine();
            _builder.BuildFrame();
        }

        /// <summary>
        /// This is an extension to the pattern template to show the car.
        /// </summary>
        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}
