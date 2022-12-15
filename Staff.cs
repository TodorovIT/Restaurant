using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Staff
    {
        private string name;
        private long salary;


        public Staff(string name, long salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public long getSalary()
        {
            return salary;
        }

        public void setSalary(long salary)
        {
            this.salary = salary;
        }

        public abstract void addsBonusToSalary();
    }
}
