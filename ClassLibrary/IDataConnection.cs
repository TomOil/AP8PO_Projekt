﻿using AP8PO_Projekt;
using AP8PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IDataConnection
    {
        Employee CreateEmployee(Employee employeeModel);
    }
}
