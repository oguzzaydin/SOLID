using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public interface IVehicle
    {
        void Fly();
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Fly()
        {
            // Car don't fly
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class AirPlane: IVehicle
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
