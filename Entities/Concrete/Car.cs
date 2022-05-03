using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public int BrandId { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string Gear { get; set; }
        public int Km { get; set; }
        public string BodyType { get; set; }
        public string EnginePower { get; set; }
        public string EngineDisplacement { get; set; }
        public string Traction { get; set; }
        public string Color { get; set; }
        public bool Guarantee { get; set; }
        public bool Swap { get; set; }
        public string Condition { get; set; }





        



    }
}
