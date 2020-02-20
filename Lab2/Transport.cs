using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    [Serializable]
    public abstract class Transport
    {
        /// <summary>
        /// Абстрактный метод PrintInfo 
        /// выводит запись в нужном формате
        /// </summary>
        public abstract void PrintInfo();
        /// <summary>
        /// Абстрактный метод CalcLoadCapacity рассчитывает грузоподъемность транспорта
        /// </summary>
        /// <returns>Возвращает число типа double, равное грузоподъемности транспортного средства </returns>
        public abstract double CalcLoadCapacity();
       public Transport() { }
    }
}
