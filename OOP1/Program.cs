namespace OOP1
{
    //1.Class
    //2.Struct
    //3.Interface
    //4.Enum


    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            // //Struct : Value Type : Stack


            // // Employee
            // // ID, Name, Salary

            // //  Point


            // Point P01;
            // // Declare For Object From Type 'Point'
            // //P01:object
            // //Allocate Uninitialized 8 Bytes at stack

            // //Console.WriteLine(P01.X);
            // //Console.WriteLine(P01.Y);

            // //P01.X = 12;
            // //P01.Y = 12;
            // //Console.WriteLine(P01.X);
            // //Console.WriteLine(P01.Y);

            // P01 = new Point(1,2);
            // // new:  Used for Select The Constructor


            // //Console.WriteLine(P01.X);
            // //Console.WriteLine(P01.Y);

            // //Console.WriteLine(P01); //OOP1.Point
            // //P01.Printpoint();

            // //Console.WriteLine(P01.ToString());//OOP1.Point
            //// Console.WriteLine(P01); //(1,2) 
            #endregion

            #region V2

            // OOP : Object Oriented Programming
            // Programming Paradim
            // OOP :The Paradim Use For Build Any Business 

            //Class : Blueprint Of The Object  
            //Object : Specific Instance From Class

            //4 pillars:- 
            //================
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Ploymorphism
            // 4. Abstraction 
            #endregion

            #region V3
            //1.Encapsulation :
            //Class Or Struct 
            //Separate The Data(Attributes) Definition From its Use 
            //[Setter Getter Method - Properties]


            //Employee
            //Id,Name,Salary

            //1.End User Access Data Itself
            //2.No Data Validation
            //3.No Read Only Filed

            //Appliy Encapsulation 
            //1.Make All Data (Attributes) Private 
            //2.Access Data Through:
            //2.1. Setter Getter Method
            //2.2. Properties 



            //Employee E01 = new Employee("Ahmed",-12000);
            //Console.WriteLine(E01);

            ////ID : Read Only Attributes

            //E01.GetId();

            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(-12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            //Console.WriteLine(E01); 
            #endregion

            Employee E01 = new Employee();
           
            E01.Id = 12;
            E01.Name = "Ahmed amin";
            E01.Salary = 12000;
            E01.Address = "cairo";

            Console.WriteLine(E01.Id);
            Console.WriteLine(E01.Name);
            Console.WriteLine(E01.Salary);
            Console.WriteLine(E01.Address);


        }
    }
}
