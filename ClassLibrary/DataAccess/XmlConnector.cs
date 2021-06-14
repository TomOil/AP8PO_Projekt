using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace ClassLibrary.DataAccess
{
    public class XmlConnector : IDataConnection
    {
        public Employee CreateEmployee(Employee employeeModel)
        {
            XmlSerialize(typeof(Employee), employeeModel, "employees.xml");

            return employeeModel;
        }

        public Group CreateGroup(Group groupModel)
        {
            XmlSerialize(typeof(Group), groupModel, "groups.xml");

            return groupModel;
        }

        public Subject CreateSubject(Subject subjectModel)
        {
            XmlSerialize(typeof(Subject), subjectModel, "subjects.xml");

            return subjectModel;
        }

        public void CreateScheduleActions(List<ScheduleAction> scheduleActionsList)
        {
            foreach (var scheduleAction in scheduleActionsList)
            {
                XmlSerialize(typeof(ScheduleAction), scheduleAction, "scheduleActions.xml");
            }
        }



        public void XmlSerialize(Type dataType, object model, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            TextWriter textWriter = new StreamWriter(filePath);
            xmlSerializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public object XmlDeserialize(Type dataType, string filePath)
        {
            object obj = null;

            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                TextReader textReader = new StreamReader(filePath);
                obj = xmlSerializer.Deserialize(textReader);
                textReader.Close();
            }

            return obj;
        }
    }
}
