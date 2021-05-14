using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClone_PrototypeDesignPattern
{
    public class SalaryLevel
    {
        public int salaryLevel;
        public double totalCTC;
        public SalaryLevel(int level,double ctc)
        {
            this.salaryLevel = level;
            this.totalCTC = ctc;
        }
    }
}
