using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.PhoneNumber = "6583215698";
            Console.WriteLine(martha.PhoneNumber);

            Customer bob = new Customer();
            bob.PhoneNumber = "5236895542";

            SalaryEmployee ted = new SalaryEmployee()
            {
                PhoneNumber = "fakeNumber",
                Salary = 120000,
                HireDate = new DateTime(1304,01,01),
            };
            Console.WriteLine(ted.YearsWithCompany);
        }
        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;
            Person newPerson = new Person();
            Console.WriteLine(newPerson.GetType());
            Console.WriteLine(firstCustomer.GetType());
            Assert.IsTrue(firstCustomer.IsPremium);
        }
        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 200000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);

            foreach(Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salary employee that makes{sEmployee.Salary}");
                }
                else if(worker is HourlyEmployee hourlyWorker)
                {
                    HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker;
                    Console.WriteLine($"{ worker.Name} HashSet worked { hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
