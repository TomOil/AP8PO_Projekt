using AP8PO_Projekt;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class XmlConnector : IDataConnection
    {
        public Employee CreateEmployee(Employee employeeModel)
        {
            employeeModel.FirstName = "Petr";

            return employeeModel;
        }
    }
}
