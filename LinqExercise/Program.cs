using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average of numbers: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console
            Console.Write("Ascending Order: ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(x => x);
            Console.Write("Descending Order: ");
            foreach (var number in descending)
            {                           
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            var greatherThanSix = numbers.Where(x => x > 6);
            Console.Write("Numbers greather than 6: ");
            foreach (var number in greatherThanSix)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            
            Console.Write("Only print 4 numbers in order: ");
            foreach (var number in numbers.OrderBy(x => x).Take(4))
            {
                Console.Write(number + " ");
            }
            Console.WriteLine() ;

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 43;
            var changeIndexFour = numbers.OrderByDescending(x => x);
            Console.Write("Index four changed: ");
            foreach (var number in changeIndexFour)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            
            Console.WriteLine();
            Console.WriteLine("Employees with first name starting with C or S: ");
            employees.Where(name => name.FirstName[0] == 'C' || name.FirstName[0] == 'S').OrderBy(name => name.FirstName).ToList().ForEach(name => Console.WriteLine(name.FullName));
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over 26 in order by First name: ");
            employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.FirstName).ToList().ForEach(emp =>  Console.WriteLine($"{emp.FullName} Age: {emp.Age}"));
            Console.WriteLine(); 

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.Write("Sum of years of experience of employess over 35 with 10 years or less experience: ");
            var yoe = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35);
            var sumYoe = yoe.Sum(emp => emp.YearsOfExperience);
            Console.Write($"{sumYoe} years");
            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.Write("Average of years of experience of employess over 35 with 10 years or less experience: ");
            var avgYoe = yoe.Average(emp => emp.YearsOfExperience);
            Console.Write($"{avgYoe} years");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee()
            {
                FirstName = "Darth",
                LastName = "Vader",
                Age = 50,
                YearsOfExperience = 35
            };
            employees.Append(newEmployee).ToList().ForEach(emp => Console.WriteLine(emp.FullName));
            

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
