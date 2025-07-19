using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct Employee
    {

        private int id;
        private string name;
        private double salary;
        //private string address;

        // Address

        #region Apply Encapsulation User Setter Getter Method
        ////Apply Encapsulation User Setter Getter Method

        ////Setter ID
        ////public void SetId(int id ) 
        ////{
        ////  this.id = id;
        ////}

        ////Getter ID
        //public int GetId()
        //{
        //    return id;
        //}

        ////Setter Name
        //public void SetName(string name) 
        //{
        //    if(name.Length>=8 && name.Length<=20)
        //    this.name = name;   
        //}

        ////Getter Name
        //public string  GetName()
        //{
        //    return name;
        //}

        ////Setter Salary
        //public void SetSalary(double salary)
        //{
        //    if(salary>0)
        //    this.salary = salary;
        //}

        ////Getter Salary
        //public double GetSalary()
        //{
        //    return salary;
        //} 

        //public Employee( string name, double salary)
        //{
        //    //SetId(id);
        //    SetName(name);
        //    SetSalary(salary);        
        //}

        //public override string ToString()
        //{
        //    return $"ID: {id} :: Name: {name} :: Salary: {salary}";
        //}

        #endregion

        //Apply Encapsulation Properties :[Recommended]
        //1.Full Porperty


        //Id
        public int Id
        {
            //set
            //get
            set
            {
                id = value;
            }
            get
            {
                return id;

            }

        }

        public string Name
        {
            set
            {
                if (value.Length >= 8 && value.Length <= 20)
                    name = value;
            }
            get
            {
                return name;
            }

        }

        public double Salary
        {
            set
            {
                if (value > 0)
                    salary = value;

            }
            get
            {
                return salary;
            }


        }

        //public string Address
        //{
        //    set 
        //    {
        //        address = value;
        //    }
        //    get 
        //    {
        //        return address;
        //    }
        
        //}

        //2.Automatic Property : Without Logic 
        public string Address { set; get; }


        //3.Special Poreperty[indexer]


    }
}
