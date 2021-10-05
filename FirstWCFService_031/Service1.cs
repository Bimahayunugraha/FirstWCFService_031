using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWCFService_031
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public double AddNumber(double number1, double number2)
        {
            return (number1 + number2);
        }
        public double SubNumber(double number1, double number2)
        {
            return (number1 - number2);
        }
        public double MultipleNumber(double number1, double number2)
        {
            return (number1 * number2);
        }
        public double DivideNumber(double number1, double number2)
        {
            return (number1 / number2);
        }
    }
}
