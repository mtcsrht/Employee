using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    internal class Solution
    {
        public List<Employee> employees = new List<Employee>();
        public Solution()
        {
            var sr = new StreamReader(@"..\..\..\src\employees.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Length > 1)
                {
                    employees.Add(new Employee(line));
                }
            }
            sr.Close();
        }
        public double AverageAge()
        {
            return employees.Average(e => e.Age);
        }
        public List<Employee> LivesInBudapest()
        {
            var returnable = employees.Select(e => e).Where(e => e.City == "Budapest").ToList();
            return returnable;
        }

        public Employee OldestPerson()
        {
            return employees.Select(e => e).OrderBy(e => e.Age).Last();
        }

        public string OlderThanFifty()
        {
            string text = "";

            if (employees.Select(e=>e).Where(e => e.Age>50).Count() > 0)
            {
                text += "True;";
                foreach(var i in employees.Select(e => e).Where(e => e.Age > 50))
                {
                    text += $"{i.Name};";
                }
            }
            else
            {
                text += "False";
            }
            return text;
        }
        
        public Employee[] YoungerThanThirty()
        {
            return employees.Select(e => e).Where(e => e.Age < 30).ToArray();
        }

        public bool OldestAndYoungest(out Employee youngest, out Employee oldest)
        {
            oldest = employees.Select(e => e).OrderBy(e => e.Age).Last();
            youngest = employees.Select(e => e).OrderByDescending(e => e.Age).Last();

            int youngestAge = employees.Select(e => e).OrderByDescending(e => e.Age).Last().Age;

            if (employees.Select(e =>e).Where(e => e.Age == youngestAge).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<string, int> OverTwelveMillion()
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (Employee emp in employees)
            {
                if (emp.YearlySalaryInHuf > 12000000)
                {
                    keyValuePairs.Add(emp.Name, emp.YearlySalaryInHuf);
                }
            }
            return keyValuePairs;
        }

        public double AveragePayment(List<Employee> e)
        {
            return e.Select(e => e.Salary).Average();
        }

        public double MaleAveragePayment()
        {
            return employees.Select(e => e).Where(e => e.Gender == "Male").Average(e => e.Salary);
        }

        public double FamaleAveragePayment()
        {
            return employees.Select(e => e).Where(e => e.Gender == "Female").Average(e => e.Salary);
        }
    }
}
