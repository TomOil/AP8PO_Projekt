﻿using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ClassLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public Employee CreateEmployee(Employee employeeModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                var parameter = new DynamicParameters();

                parameter.Add("@firstName", employeeModel.FirstName);
                parameter.Add("@lastName", employeeModel.LastName);
                parameter.Add("@workEmail", employeeModel.WorkEmail);
                parameter.Add("@personalEmail", employeeModel.PersonalEmail);
                parameter.Add("@workPhoneNumber", employeeModel.WorkPhoneNumber);
                parameter.Add("@personalPhoneNumber", employeeModel.PersonalPhoneNumber);
                parameter.Add("@isDoctoralStudent", employeeModel.DoctoralStudent);
                parameter.Add("@employeeLoad", employeeModel.EmployeeLoad);
                parameter.Add("@pointsAll", employeeModel.pointsAll);
                parameter.Add("@pointsCZ", employeeModel.pointsCZ);
                parameter.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployeeTable_Insert", parameter, commandType: CommandType.StoredProcedure);

                //employeeModel.Id = parameter.Get<int>("@id");

                return employeeModel;
            }
        }

        public Group CreateGroup(Group groupModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                var parameter = new DynamicParameters();

                parameter.Add("@name", groupModel.Name);
                parameter.Add("@nameShort", groupModel.NameShort);
                parameter.Add("@grade", groupModel.Grade);
                parameter.Add("@semester", groupModel.Semester);
                parameter.Add("@numberOfStudents", groupModel.NumberOfStudents);
                parameter.Add("@formOfStudy", groupModel.FormOfStudy);
                parameter.Add("@typeOfStudy", groupModel.TypeOfStudy);
                parameter.Add("@language", groupModel.Language);
                parameter.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spGroupTable_Insert", parameter, commandType: CommandType.StoredProcedure);

                groupModel.Id = parameter.Get<int>("@id");

                return groupModel;
            }
        }

        public Subject CreateSubject(Subject subjectModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                var parameter = new DynamicParameters();

                parameter.Add("@name", subjectModel.Name);
                parameter.Add("@nameShort", subjectModel.NameShort);
                parameter.Add("@numberOfWeeks", subjectModel.NumberOfWeeks);
                parameter.Add("@lectureHours", subjectModel.LectureHours);
                parameter.Add("@practiceHours", subjectModel.PracticeHours);
                parameter.Add("@seminarHours", subjectModel.SeminarHours);
                parameter.Add("@formOfCompletion", subjectModel.FormOfCompletion);
                parameter.Add("@language", subjectModel.Language);
                parameter.Add("@classSize", subjectModel.ClassSize);
                parameter.Add("@credits", subjectModel.Credits);
                parameter.Add("@guarantorInstitute", subjectModel.GuarantorInstitute);
                parameter.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spSubjectTable_Insert", parameter, commandType: CommandType.StoredProcedure);

                subjectModel.Id = parameter.Get<int>("@id");

                return subjectModel;
            }
        }
        public void CreateScheduleActions(List<ScheduleAction> scheduleActionsList)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                foreach (var scheduleAction in scheduleActionsList)
                {
                    var parameter = new DynamicParameters();

                    parameter.Add("@title", scheduleAction.Title);
                    parameter.Add("@groupName", scheduleAction.GroupName);
                    parameter.Add("@subjectId", scheduleAction.SubjectId);
                    parameter.Add("@type", scheduleAction.Type);
                    parameter.Add("@numberOfStudents", scheduleAction.NumberOfStudents);
                    parameter.Add("@numberOfHours", scheduleAction.NumberOfHours);
                    parameter.Add("@numberOfWeeks", scheduleAction.NumberOfWeeks);
                    parameter.Add("@language", scheduleAction.Language);
                    parameter.Add("@points", scheduleAction.Points);
                    parameter.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spScheduleAction_Insert", parameter, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
