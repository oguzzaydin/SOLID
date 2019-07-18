using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public interface ICar
    {
        void Drive();
    }

    public interface IAirPlane
    {
        void Fly();
    }

    public class Ferrari: ICar
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Plane : IAirPlane
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class SuperVehicle : ICar, IAirPlane
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
