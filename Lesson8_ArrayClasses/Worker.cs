using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Worker
    {
        string name;
        uint age, salary;

        public Worker()
        {
            this.name = "Имя Фамилия Отчество";
            this.age = 18;
            this.salary = 3200;
        }

        public Worker(string name, uint age, uint salary)
        {
            this.name = name;
            Age = age;
            this.salary = salary;
        }

        /// <summary>
        /// Имя фамилия отчество
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Возраст лет
        /// </summary>
        public uint Age { get => age; set => age = (value > 18 ? value : 18); }
        /// <summary>
        /// Зароботная плата в гривнах
        /// </summary>
        public uint Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"ФИО:{this.name}\nВозраст лет:{this.age}\nЗароботная плата гривен:{this.salary}";
        }
    }
}
