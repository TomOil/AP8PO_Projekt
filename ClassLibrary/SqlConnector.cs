using AP8PO_Projekt;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class SqlConnector : IDataConnection
    {
        public Employee CreateEmployee(Employee employeeModel)
        {
            employeeModel.FirstName = "Pavel";

            return employeeModel;
        }
    }
}
