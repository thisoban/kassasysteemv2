using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace IDal
{
    public interface IDalEmployee
    {
        EmployeeModel EmployeeDetail(int number);

        bool EmployeeUpdate(EmployeeModel employee);

        bool EmployeeRemove(int employeeid);

        bool EmployeeCreate(EmployeeModel employee);

        List<EmployeeModel> Employees();
    }
}
