using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ClassLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Save the employee to the db
        public Employee CreateEmployee(Employee employeeModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
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
                parameter.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployeeTable_Insert", parameter, commandType: CommandType.StoredProcedure);

                employeeModel.Id = parameter.Get<int>("@id");

                return employeeModel;
            }
        }
    }
}
