using System;

namespace Facade_Design_Pattern
{
    public class Engine
    {

        public string injectFuel()
        {
            return " Fuel Injecting ";
        }

        public string igniteFuel()
        {
            return " ignite Fueling ";
        }

    }
    public class Headlights
    {
        public string TurnOn() {
            return " Turned on Headlights ";
        }
        
    }

    class ChangeGearOfCar
    {
        public string ChangeGear()
        {
            return " Gear Changed ";
        }
    }

    class Accelerate
    {
        public string PressAccelerate()
        {
            return " Accelerating ";
        }
    }

    class Car
    {
        Engine engine;
        Headlights hdligt;
        ChangeGearOfCar gear;
        Accelerate acc;

       public Car()
        {
            this.engine = new  Engine();
            this.hdligt = new Headlights();
            this.gear = new ChangeGearOfCar();
            this.acc = new Accelerate();
        }
        public void StartCar()
        {
            Console.WriteLine(
           engine.injectFuel()+"\n"+
            engine.igniteFuel() + "\n" +
            hdligt.TurnOn()

                );
            
        }

        public void moveCar()
        {
            Console.WriteLine(
           gear.ChangeGear() + "\n" +
            acc.PressAccelerate()
            );
        }

    }
    // Facade
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartCar();
            car.moveCar();

        }
    }
}
