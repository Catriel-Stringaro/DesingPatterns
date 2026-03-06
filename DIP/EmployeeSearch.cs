using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    /// <summary>
    /// Acoplado
    /// </summary>
    //public class EmployeeSearch
    //{
    //    private readonly EmployeeManager employeeSearch;

    //    public EmployeeSearch(EmployeeManager employeeManager)
    //    {
    //        this.employeeSearch = employeeManager;
    //    }

    //    public int GetMaleExecutives()
    //    {
    //        throw new NotImplementedException();
    //    }

    //}

    /// <summary>
    /// desacoplado
    /// </summary>
    public class EmployeeSearch
    {
        private readonly IEmployeeSearcheable employeeSearch;

        public EmployeeSearch(IEmployeeSearcheable employeeManager)
        {
            this.employeeSearch = employeeManager;
        }

        public int GetEmployeesByGenderAndRole(Gender gender, Role role)
        {
            return employeeSearch.GetEmployeesByGenderAndRole(gender, role);
        }

    }

}
