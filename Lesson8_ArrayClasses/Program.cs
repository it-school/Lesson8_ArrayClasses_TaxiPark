using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company(10);

            Transport transport1 = new Transport("111111111111111", "vn1111vn", 5f);
            Transport transport2 = new Transport("222222222222222", "vn2222vn", 5f);
            Transport transport3 = new Transport("333333333333333", "vn3333vn", 5f);

            company.AddTransport(transport1, 5);
            company.AddTransport(transport2, 5);
            company.AddTransport(transport3, 5);

            Worker worker1 = new Worker("Василий", 30, 8000);
            Worker worker2 = new Worker();
            Worker worker3 = new Worker("Петр", 50, 7000);
            Worker worker4 = new Worker("Коля", 25, 8000);


            
            company.AddWorker(worker1, 1);
            company.AddWorker(worker3, 1);
            company.AddWorker(worker3, 2);
            company.AddWorker(worker4, 2);


            Console.WriteLine(company);
            Console.WriteLine("--------------------------");

            company.RemoveWorker(1, 1);

            Console.WriteLine(company);
        }
    }
}
