using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Transport
    {
        string vinCode, number;
        float volume;

        public Transport()
        {
            this.vinCode = "0000000000000000";
            this.number = "ВН0000ВН";
            this.volume = 1f;
        }

        public Transport(string vinCode, string number, float volum)
        {
            this.vinCode = vinCode;
            this.number = number;
            Volume = volum;
        }

        /// <summary>
        /// ВИН код траспортного средства
        /// </summary>
        public string VinCode { get => vinCode; set => vinCode = value; }
        /// <summary>
        /// Номер траспортного средства пример: ВН0000ВН
        /// </summary>
        public string Number { get => number; set => number = value; }
        /// <summary>
        /// Обьем двигателя от 0.1 до 10.0 в литрах
        /// </summary>
        public float Volume { get => volume; set => volume = (value > 0 && value < 10) ? value : 1f; }


        public override string ToString()
        {
            return $"ВИН код:{this.vinCode}\nНомер:{this.number}\nОбьем двигателя:{this.Volume}";
        }
    }
}
