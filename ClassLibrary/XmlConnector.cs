using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class XmlConnector : IDataConnection
    {
        //TODO - Save employee to the xml file
        public Employee CreateEmployee(Employee employeeModel)
        {
            employeeModel.Id = 2;

            return employeeModel;
        }
    }
}
