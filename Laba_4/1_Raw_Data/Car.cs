using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Raw_Data
{
    class Car
    {
        public string model;
        public int engineSpeed;
        public int enginePower;
        public int cargoWeight;
        public string cargoType;
        public KeyValuePair<double, int>[] tires;


        public Car( string model,
                    int engineSpeed, int enginePower,
                    int cargoWeight, string cargoType,
                    double tire1Pressure, int tire1Age,
                    double tire2Pressure, int tire2Age,
                    double tire3Pressure, int tire3age,
                    double tire4Pressure, int tire4age)
        {
            this.model = model;
            Engine engine = new Engine(engineSpeed, enginePower);
            this.engineSpeed = engine.engineSpeed;
            this.enginePower = engine.enginePower;

            Cargo cargo = new Cargo(cargoWeight, cargoType);
            this.cargoWeight = cargo.cargoWeight;
            this.cargoType = cargo.cargoType;

            Tire tires = new Tire(tire1Pressure, tire1Age,
                                 tire2Pressure, tire2Age,
                                 tire3Pressure, tire3age,
                                 tire4Pressure, tire4age );
            this.tires = tires.tires;

        }
        
    }
}
