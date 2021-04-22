using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {

            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector financiero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position JefeFinPosition = new Position();
            JefeFinPosition.Name = "Jefe financiero";
            JefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector académico";
            vicAcadPosition.Salary = 780;

            Position jefereg = new Position();
            jefereg.Name = "Jefe reg ";
            jefereg.Salary = 640;

            Position sectreg2 = new Position();
            sectreg2.Name = "Secretaria reg 2";
            sectreg2.Salary = 360;

            Position sectreg1 = new Position();
            sectreg1.Name = "Secretaria reg 1";
            sectreg1.Salary = 400;

            Position asist2 = new Position();
            asist2.Name = "Asistente 2";
            asist2.Salary = 170;

            Position mensajero = new Position();
            mensajero.Name = "Mensajero";
            mensajero.Salary = 90;

            Position asist1 = new Position();
            asist1.Name = "Asistente 1";
            asist1.Salary = 250;

            UniversityTree universityTree = new UniversityTree();

            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, JefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefereg, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectreg2, jefereg.Name);

            universityTree.CreatePosition(universityTree.Root, sectreg1, jefereg.Name);
            universityTree.CreatePosition(universityTree.Root, asist2, sectreg1.Name);
            universityTree.CreatePosition(universityTree.Root, mensajero, asist2.Name);

            universityTree.CreatePosition(universityTree.Root, asist1, sectreg1.Name);

            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");
            Console.ReadLine();

        }
    }
}
