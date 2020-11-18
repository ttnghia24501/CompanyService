using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Companyservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Companyservice.svc or Companyservice.svc.cs at the Solution Explorer and start debugging.
    public class Companyservice : ICompanyService
    {
        public bool createDepartment(Department newDepartment)
        {
            throw new NotImplementedException();
        }

        public bool createEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public bool deleteDepartment(string id)
        {
            throw new NotImplementedException();
        }

        public bool deleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public bool editDepartment(string id, Department newDepartment)
        {
            throw new NotImplementedException();
        }

        public bool editEmployee(string id, Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public List<Department> getDepartments()
        {
            throw new NotImplementedException();
        }

        public List<Employee> getEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
