using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct Employee
    {

        private int id ;
        private string name;
        private double salary;

        //Apply Encapsulation User Setter Getter Method

        //Setter ID
        //public void SetId(int id ) 
        //{
        //  this.id = id;
        //}

        //Getter ID
        public int GetId()
        {
            return id;
        }

        //Setter Name
        public void SetName(string name) 
        {
            if(name.Length>=8 && name.Length<=20)
            this.name = name;   
        }

        //Getter Name
        public string  GetName()
        {
            return name;
        }

        //Setter Salary
        public void SetSalary(double salary)
        {
            if(salary>0)
            this.salary = salary;
        }

        //Getter Salary
        public double GetSalary()
        {
            return salary;
        }



        public Employee( string name, double salary)
        {
            //SetId(id);
            SetName(name);
            SetSalary(salary);        
        }

        public override string ToString()
        {
            return $"ID: {id} :: Name: {name} :: Salary: {salary}";
        }






    }
}
