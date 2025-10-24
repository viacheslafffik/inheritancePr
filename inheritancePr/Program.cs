using System;

namespace inheritancePr
{
    internal class Program
    {
        public interface IReportable
        {
            void GenerateReport();
        }

        public class Employee
        {
            public decimal salary { get; set; }

            public virtual decimal CalculateBonus()
            {
                return salary * 0;
            }
        }

        public class Manager : Employee, IReportable
        {
            public override decimal CalculateBonus() => salary * 0.2m;
            

            public void GenerateReport()
            {
                // можна було б додати в Employee ім'я і виводити тут
                Console.WriteLine("Звiт від менеджера зроблено*\n\n");
            }
        }

        public class Developer : Employee
        {
            public override decimal CalculateBonus() =>  salary * 0.1m;
        }

        static void Main(string[] args)
        {
            Manager manager = new Manager { salary = 10000.50m};
            Console.WriteLine($"Менеджер отримує зарплатню {manager.salary}\n" +
                $"також iз бонусом 20%, що додає {manager.CalculateBonus()}\n" +
                $"разом виходить {manager.salary + manager.CalculateBonus()}" +
                $"\n-----------------------------------------------");
            manager.GenerateReport();


            Developer developer = new Developer { salary = 13089m};
            Console.WriteLine($"Менеджер отримує зарплатню {developer.salary}\n" +
                $"також iз бонусом 20%, що додає {developer.CalculateBonus()}\n" +
                $"разом виходить {developer.salary + developer.CalculateBonus()}" +
                $"\n-----------------------------------------------");
        }
    }
}
