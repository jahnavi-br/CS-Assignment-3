using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Assignment_3
{
    class Manager:Employees
    {
        private double PetrolAllowance = 0.08;
        private double FoodAllowance = 0.13;
        private double OtherAllowance = 0.03;
        private double Grosssalary = 0.0;


        //Calling base class No parameter Constructor 

        //Calling base class's parameterized Constructor 
        //and passing parameters of base class(Employee)
        //Using Base class Constructor

        public Manager(int id, String name, Date JoiningDt, Department department, double salary)
            : base(id, name, salary, JoiningDt, department)
        {

        }
        public double Food_Allowance
        {
            get { return FoodAllowance; }
            set { FoodAllowance = value; }
        }

        public double Other_Allowance
        {
            get { return OtherAllowance; }
            set { OtherAllowance = value; }
        }

        public double PetrolAllowance1 { get => PetrolAllowance; set => PetrolAllowance = value; }


        //Ovrriding CalculateSalary() method of base class(Enployee)
        public override double CalculateSalary()
        {
            Grosssalary = base.Salary + (base.Salary * PetrolAllowance1) + (base.Salary * Food_Allowance) + (base.Salary * Other_Allowance);
            return Grosssalary;
        }
        //Overriding ToString Method for string representation of an object
        public override string ToString()
        {
            return base.ToString() + "\nPetrol Allowance = " + PetrolAllowance1 + "\nFood Allowance = " + Food_Allowance + "\nOther Allowance = " + Other_Allowance + "\nGross Salary = " + CalculateSalary();
        }

    }
}
