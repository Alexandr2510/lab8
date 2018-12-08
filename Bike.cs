using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Bike
    {
        private int katafoti;
        private int weight;

        public string Nazv { get; set; }

        public string Klass { get; set; }

        public string Type { get; set; }

        public string Color { get; set; }

        public int Katafoti
        {
            get { return katafoti; }
            set
            {
                if (value > 0)
                    katafoti = value;
                else
                    throw new InvalidKatafotiException();
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    throw new InvalidWeightException();
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Назва: {0}    \n" + 
                "Клас: {1}    \n" + 
                "Тип: {2}    \n" +
                "Колір: {3}    \n" +
                "Кількість катафотів: {4}    \n" +
                "Вес: {5} кг    \n", Nazv, Klass, Type, Color, Katafoti, Weight
                );
        }
    }

    public class BikeException : Exception
    {
        public BikeException(string messange) : base(messange) { }
    }

    public class InvalidKatafotiException : BikeException
    {
        public InvalidKatafotiException() : base("Invalid katafoti input") { }
    }

    public class InvalidWeightException : BikeException
    {
        public InvalidWeightException() : base("Invalid weight input") { }
    }
}