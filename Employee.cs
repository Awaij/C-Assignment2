using System;

namespace LitwareLib
{
    public class Employee
    {
        private int empno;
        public int Empno { get; set; }

        private string empname;
        public string Empname { get; set; }

        private double salary;
        public double Salary { get; set; }
        private double HRA;
        public double EHRA { get; set; }
        private double TA;
        public double ETA { get; set; }
        private double DA;
        public double EDA { get; set; }
        private double PF;
        public double EPF { get; set; }
        private double TDS;
        public double ETDS { get; set; }
        private double nsal;
        public double Ensal { get; set; }
        private double gsal;
        public double Egsal { get; set; }


        public double EmployeeDetails(int empno, string empname, double salary)
        {
            Console.WriteLine(".....Enter Employee Details.....");

            Console.WriteLine("Enter employee number");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee Name");
            empname = Console.ReadLine();

            Console.WriteLine("Enter employee Salary");
            salary = double.Parse(Console.ReadLine());

            if (salary < 5000)
            {
                HRA = salary * 10 / 100 + 10/100;
                TA = salary * 5 / 100 + 5 / 100;
                DA = salary * 15 / 100 + 15 / 100;

                gsal = salary + HRA + TA + DA;
                Console.WriteLine("Gross Salary = " + gsal);

                return gsal;
            }
            else if (salary < 10000)
            {
                HRA = salary * 15/100 + 15/100;
                TA = salary * 10/100 + 10/100;
                DA = salary * 20 / 100 + 20/100;
                
                gsal = salary + HRA + TA + DA;
                Console.WriteLine("Gross Salary = " + gsal);

                return gsal;
            }
            else if (salary < 15000)
            {
                HRA = salary * 20 / 100 + 20/100;
                TA = salary * 15 / 100 + 15/100;
                DA = salary * 25 / 100 + 25/100;

                gsal = salary + HRA + TA + DA;
                Console.WriteLine("Gross Salary = " + gsal);

                return gsal;
            }
            else if (salary < 20000)
            {
                HRA = salary * 25 / 100 + 25/100;
                TA = salary * 20 / 100 + 20/100;
                DA = salary * 30 / 100 + 30/100;

                gsal = salary + HRA + TA + DA;
                Console.WriteLine("Gross Salary = " + gsal);

                return gsal;
            }
            else
            {
                HRA = salary * 30 / 100 + 30/100;
                TA = salary * 25 / 100 + 25/100;
                DA = salary * 35 / 100 + 35/100;
                               
                gsal = salary + HRA + TA + DA;
                Console.WriteLine("Gross Salary = " + gsal);
                
                return gsal;
            }
        }
        public void calculatesalary()
        {
            double data = EmployeeDetails(09, "Aiman", 28000);
            PF = data * 10/100 + 10/100;
            TDS = data * 18/100 + 18/100;
            nsal = data - (PF + TDS);
            Console.WriteLine("Net Salary = "+ nsal);
        }
    }
}
