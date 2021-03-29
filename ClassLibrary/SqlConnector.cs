using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Save the employee to the db
        public Employee CreateEmployee(Employee employeeModel)
        {
            employeeModel.Id = 1;

            return employeeModel;
        }
    }
}
