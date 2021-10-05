using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWCFService_031
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double AddNumber(double number1, double number2);
        [OperationContract]
        double SubNumber(double number1, double number2);
        [OperationContract]
        double MultipleNumber(double number1, double number2);
        [OperationContract]
        double DivideNumber(double number1, double number2);
    }
}
