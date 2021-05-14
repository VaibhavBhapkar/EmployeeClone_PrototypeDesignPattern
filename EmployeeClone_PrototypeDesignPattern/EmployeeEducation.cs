using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClone_PrototypeDesignPattern
{
    public class EmployeeEducation
    {
        public string employeeDegree;
        public string degreeProvider;
        public SalaryLevel salaryStructure;

        public EmployeeEducation ShallowCopy()
        {
            return (EmployeeEducation)this.MemberwiseClone();
        }

        public EmployeeEducation DeepCopy()
        {
            EmployeeEducation employeeClone = (EmployeeEducation)this.MemberwiseClone();
            employeeClone.salaryStructure = new SalaryLevel(salaryStructure.salaryLevel,salaryStructure.totalCTC);
            return employeeClone;
        }
    }
}
