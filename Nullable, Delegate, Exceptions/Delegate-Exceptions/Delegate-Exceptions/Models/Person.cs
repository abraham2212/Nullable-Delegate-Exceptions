using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exceptions.Models
{
    internal class Person :IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }

        public double GetSalary( double salary)
        {
            return Persons.FindAll(m=>m.Salary>salary).Count;
        }

        private List<Person> GetAll()
        {
            return new List<Person>() { new Person { Id = 1, Name = "ALI", Surname = "aliyev", Salary = 3000 } };
                new List<Person>() { new Person { Id = 2, Name = "aqil", Surname = "zakirov", Salary = 2000 } };
                
        }
    }

}
