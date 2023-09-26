using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int Salary { get; set; }
        public int YearlySalaryInHuf{
            get
            {
                return (Salary * 12) * 390;
            }
            }
        public Employee(string row)
        {
            string[] tmp = row.Split(';');
            Name = tmp[0];
            Age = int.Parse(tmp[1]);
            City = tmp[2];
            Department = tmp[3];
            Position = tmp[4];
            Gender = tmp[5];
            MaritalStatus = tmp[6];
            Salary = int.Parse(tmp[7]);
        }
        public virtual void DataOut()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}, Department: {Department}, Position: {Position}, Gender: {Gender}, MaritalStatus: {MaritalStatus}, Salary: {Salary}");
        }

    }
}
