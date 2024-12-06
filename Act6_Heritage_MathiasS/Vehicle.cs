using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    internal abstract class Vehicle
    {
        protected string _marque;
        protected int _fuel;

        public Vehicle(string marque, int fuel)
        {
            _marque = marque;
            _fuel = fuel;
        }
    }
    internal abstract class RoadVehicle : Vehicle
    {
        protected double _km;
        public RoadVehicle(string marque, int fuel, double km) : base (marque, fuel)
        {
            _km = km;
        }
    }
    internal  class Boat : Vehicle
    {
        protected double _tn;
        public Boat(string marque, int fuel, double tn) : base(marque, fuel)
        {
            _tn = tn;
        }
    }
    internal class Plane : Vehicle
    {
        protected double _range;
        public Plane(string marque, int fuel, double r) : base(marque, fuel)
        {
            _range = r;
        }
    }
    internal class Car : RoadVehicle
    {
        public Car(string marque, int fuel, int km) : base(marque, fuel, km)
        {
        }
    }
    internal class Truck : RoadVehicle
    {
        double _tn;
        public Truck(string marque, int fuel, double km, double tn) : base(marque, fuel, km)
        {
            _tn = tn;
        }
    }
}
