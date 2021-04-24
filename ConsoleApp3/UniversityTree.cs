using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles_Binarios
{
    class UniversityEmployee
    {
        BinaryTree<Object> ob = new BinaryTree<Object>();

        private string name;
        private float salary;
        private float total;

        public UniversityEmployee(string name, float salary)
        {
            Salary = salary;
            Name = name;
            Total += salary;
        }

        public UniversityEmployee()
        {

        }

        public string Name { get => name; set => name = value; }
        public float Salary { get => salary; set => salary = value; }
        public float Total { get => total; set => total = value; }

        public override string ToString()
        {
            return $"{Name}: {Salary}";
        }
    }
}