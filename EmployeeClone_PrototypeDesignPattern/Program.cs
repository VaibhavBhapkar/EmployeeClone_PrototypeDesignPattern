using System;

namespace EmployeeClone_PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment operator for clone

            EmployeeEducation employeeEducation=new EmployeeEducation();
            employeeEducation.employeeDegree = "BE";
            employeeEducation.degreeProvider = "Tier3";
            SalaryLevel salaryLevel = new SalaryLevel(50,500000);
            employeeEducation.salaryStructure = salaryLevel;

            EmployeeEducation employeeEducationClone = new EmployeeEducation();
            employeeEducationClone = employeeEducation;
            employeeEducation.employeeDegree = "B.Tech";
            employeeEducation.salaryStructure.salaryLevel=51;
            employeeEducation.salaryStructure.totalCTC = 1000000;

            Console.WriteLine("Assignemnt Operator");

            Console.WriteLine("Education 1 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation.employeeDegree, employeeEducation.degreeProvider, employeeEducation.salaryStructure.salaryLevel, employeeEducation.salaryStructure.totalCTC);

            Console.WriteLine("Education 2 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducationClone.employeeDegree, employeeEducationClone.degreeProvider, employeeEducationClone.salaryStructure.salaryLevel, employeeEducationClone.salaryStructure.totalCTC);


            //Shallow Copy & Deep Copy

            EmployeeEducation employeeEducation1 = new EmployeeEducation();
            employeeEducation1.employeeDegree = "BE";
            employeeEducation1.degreeProvider = "Tier3";
            SalaryLevel salaryLevel1 = new SalaryLevel(50, 500000);
            employeeEducation1.salaryStructure = salaryLevel1;

            EmployeeEducation employeeEducation2 = new EmployeeEducation();

            EmployeeEducation employeeEducation3 = new EmployeeEducation();

            employeeEducation2 = employeeEducation1.ShallowCopy();
            employeeEducation3 = employeeEducation1.DeepCopy();

            Console.WriteLine("Before Any Change Shallow & Deep Copy");

            Console.WriteLine("Education 1 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation1.employeeDegree, employeeEducation1.degreeProvider, employeeEducation1.salaryStructure.salaryLevel, employeeEducation1.salaryStructure.totalCTC);

            Console.WriteLine("Education 2 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation2.employeeDegree, employeeEducation2.degreeProvider, employeeEducation2.salaryStructure.salaryLevel, employeeEducation2.salaryStructure.totalCTC);

            Console.WriteLine("Education 3 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation3.employeeDegree, employeeEducation3.degreeProvider, employeeEducation3.salaryStructure.salaryLevel, employeeEducation3.salaryStructure.totalCTC);

            employeeEducation1.degreeProvider = "Tier1";
            employeeEducation1.employeeDegree = "B.Tech";
            employeeEducation1.salaryStructure.salaryLevel = 52;
            employeeEducation1.salaryStructure.totalCTC = 1200000;

            Console.WriteLine("After Change in Education 1 Shallow & Deep Copy");

            Console.WriteLine("Education 1 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation1.employeeDegree, employeeEducation1.degreeProvider, employeeEducation1.salaryStructure.salaryLevel, employeeEducation1.salaryStructure.totalCTC);

            Console.WriteLine("Education 2 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation2.employeeDegree, employeeEducation2.degreeProvider, employeeEducation2.salaryStructure.salaryLevel, employeeEducation2.salaryStructure.totalCTC);

            Console.WriteLine("Education 3 - Degree {0}, Provider {1}, SalaryLevel {2},SalaryCTC {3}", employeeEducation3.employeeDegree, employeeEducation3.degreeProvider, employeeEducation3.salaryStructure.salaryLevel, employeeEducation3.salaryStructure.totalCTC);

        }
    }
}
