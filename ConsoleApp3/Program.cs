using System;

namespace Arboles_Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<UniversityEmployee> employees = new BinaryTree<UniversityEmployee>();

            UniversityEmployee rectorPosition = new UniversityEmployee();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            UniversityEmployee vicFinPosition = new UniversityEmployee();
            vicFinPosition.Name = "Vicerector financiero";
            vicFinPosition.Salary = 750;

            UniversityEmployee contadorPosition = new UniversityEmployee();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;

            UniversityEmployee jefeFinancieroPosition = new UniversityEmployee();
            jefeFinancieroPosition.Name = "Jefe Financiero";
            jefeFinancieroPosition.Salary = 610;

            UniversityEmployee secretary1Position = new UniversityEmployee();
            secretary1Position.Name = "Secretaria 1";
            secretary1Position.Salary = 350;

            UniversityEmployee vicAdemicaPosition = new UniversityEmployee();
            vicAdemicaPosition.Name = "Vic academica";
            vicAdemicaPosition.Salary = 780;

            UniversityEmployee secretary2Position = new UniversityEmployee();
            secretary2Position.Name = "Secretaria 2";
            secretary2Position.Salary = 310;

            UniversityEmployee jefeRegPosition = new UniversityEmployee();
            jefeRegPosition.Name = "Jefe Reg";
            jefeRegPosition.Salary = 640;

            UniversityEmployee secretreg2Position = new UniversityEmployee();
            secretreg2Position.Name = "Secretreg2";
            secretreg2Position.Salary = 360;

            UniversityEmployee Secreg1Position = new UniversityEmployee();
            Secreg1Position.Name = "secreg1";
            Secreg1Position.Salary = 780;


            employees.addPrioridadIzquierda(employees.raiz, rectorPosition);
            employees.addPrioridadIzquierda(employees.raiz, vicFinPosition);
            employees.addPrioridadIzquierda(employees.raiz, contadorPosition);
            employees.addPrioridadIzquierda(employees.raiz, jefeFinancieroPosition);
            employees.addPrioridadIzquierda(employees.raiz, secretary1Position);
            employees.addPrioridadIzquierda(employees.raiz, vicAdemicaPosition);
            employees.addPrioridadIzquierda(employees.raiz, secretary2Position);
            employees.addPrioridadIzquierda(employees.raiz, jefeRegPosition);
            employees.addPrioridadIzquierda(employees.raiz, secretreg2Position);
            employees.addPrioridadIzquierda(employees.raiz, Secreg1Position);


            Console.WriteLine("\n\nPreorden");

            employees.PreOrden(employees.raiz);

            UniversityEmployee em = new UniversityEmployee();
            Console.WriteLine(em.Total);
        }
    }
}