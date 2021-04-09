using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess
{
    public class XmlConnector : IDataConnection
    {
        //TODO - Save employee to the xml file
        public Employee CreateEmployee(Employee employeeModel)
        {
            employeeModel.Id = 2;

            return employeeModel;
        }

        public Group CreateGroup(Group groupModel)
        {
            groupModel.Id = 2;

            return groupModel;
        }

        public Subject CreateSubject(Subject subjectModel)
        {
            subjectModel.Id = 2;

            return subjectModel;
        }
    }
}
