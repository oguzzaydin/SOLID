using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.L
{
    public class Ferrari: Car, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima çalışıyor..";
        }
    }
}
