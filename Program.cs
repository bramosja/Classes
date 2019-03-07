using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string title { get; set; }

        public DateTime startdate { get; set; }
    }
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }


        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string name, DateTime CreatedDate){
            Name = name;
            CreatedOn = CreatedDate;
        }

        public void ListEmployees() {

            foreach(Employee IndvEmployee in Employees){
                string newName = $"{IndvEmployee.firstname} {IndvEmployee.lastname}";
                Console.WriteLine(newName);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company BearBoots = new Company("BearBoots", DateTime.Today);

            Employee Allison = new Employee();

            Allison.firstname = "Allison";

            Allison.lastname = "Collins";

            Allison.title = "Star Vet";

            Allison.startdate = DateTime.Now;

            Employee Dan = new Employee();

            Dan.firstname = "Dan";

            Dan.lastname = "Brewsky";

            Dan.title = "Vet Assistant";

            Dan.startdate = DateTime.Now;

            Employee Mary = new Employee();

            Mary.firstname = "Mary";

            Mary.lastname = "Remo";

            Mary.title = "Soda Jerk";

            Mary.startdate = DateTime.Now;

            BearBoots.Employees = new List<Employee>();

            BearBoots.Employees.Add(Allison);
            BearBoots.Employees.Add(Dan);
            BearBoots.Employees.Add(Mary);

            BearBoots.ListEmployees();




            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
