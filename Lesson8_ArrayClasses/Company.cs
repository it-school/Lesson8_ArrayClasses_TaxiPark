using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Company
    {
        Transport[] transports;
        bool[] deletedTransports;
        uint totalTransportsQuantity = 0, currentTransportsQuantity = 0;

        Worker[][] workers;
        bool[][] deletedWorkers;
        uint[] totalWorkersQuantity = new uint[10], currentWorkersQuantity;

        public Company(uint totalTransportsQuantity)
        {
            this.totalTransportsQuantity = totalTransportsQuantity;
            transports = new Transport[totalTransportsQuantity];
            deletedTransports = new bool[totalTransportsQuantity];

            workers = new Worker[totalTransportsQuantity][];
            deletedWorkers = new bool[totalTransportsQuantity][];
            totalWorkersQuantity = new uint[totalTransportsQuantity];
            currentWorkersQuantity = new uint[totalTransportsQuantity];

            for (int i = 0; i < deletedTransports.Length; i++)
                deletedTransports[i] = true;
        }
        
        public bool AddTransport(Transport transport, uint totalWorkersQuantity)
        {
            bool result = false;

            if (currentTransportsQuantity < totalTransportsQuantity)
            {
                deletedTransports[currentTransportsQuantity] = false;
                transports[currentTransportsQuantity] = transport;

                workers[currentTransportsQuantity] = new Worker[totalWorkersQuantity];
                deletedWorkers[currentTransportsQuantity] = new bool[totalWorkersQuantity];
                this.totalWorkersQuantity[currentTransportsQuantity] = totalWorkersQuantity;

                for (int i = 0; i < deletedWorkers[currentTransportsQuantity].Length; i++)
                    deletedWorkers[currentTransportsQuantity][i] = true;

                currentTransportsQuantity++;
                result = true;
            }

            return result;
        }

        public bool RemoveTransport(uint transportNumber)
        {
            bool result = false;

            if ((transportNumber < currentTransportsQuantity) && (transportNumber > 0))
            {
                deletedTransports[transportNumber - 1] = true;

                for (int i = 0; i < deletedWorkers[transportNumber - 1].Length; i++)
                    deletedWorkers[transportNumber - 1][i] = true;

                result = true;
            }

            return result;
        }

        public bool AddWorker(Worker worker, uint transportNumber)
        {
            bool result = false;

            transportNumber--;
            if (currentWorkersQuantity[transportNumber] < totalWorkersQuantity[transportNumber])
            {
                deletedWorkers[transportNumber][currentWorkersQuantity[transportNumber]] = false;
                workers[transportNumber][currentWorkersQuantity[transportNumber]] = worker;
                currentWorkersQuantity[transportNumber]++;
                result = true;
            }

            return result;
        }

        public bool RemoveWorker(uint transportNumber, uint workerNumber)
        {
            bool result = false;

            if (((transportNumber < currentTransportsQuantity) && (transportNumber > 0)) && ((workerNumber < currentWorkersQuantity[transportNumber-1]) && (workerNumber > 0)))
            {
                deletedWorkers[transportNumber-1][workerNumber - 1] = true;
                result = true;
            }

            return result;
        }
        
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < currentTransportsQuantity; i++)
            {
                if (this.deletedTransports[i] == false)
                {
                    result += "Транспорт №" + (i + 1) + '\n' + transports[i] + '\n' + "Работают:\n";
                    for (int j = 0; j < currentWorkersQuantity[i]; j++)
                    {
                        if (this.deletedWorkers[i][j] == false)
                        {
                            result += workers[i][j] + "\n";
                        }
                    }
                }
            }

            return result;
        }

        public uint TotalTransportsQuantity { get => totalTransportsQuantity; }
        public uint CurrentTransportsQuantity { get => currentTransportsQuantity; }
        internal Transport[] Transports { get => transports; set => transports = value; }
    }
}
