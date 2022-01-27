using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Animals
    {
        public Animals(string name, int age, double weigth)
        {
            Name = name;
            Age = age;
            Weigth = weigth;
        }

        public Animals() { }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weigth { get; set; }

        public override string ToString()
        {
            return $"Группа - Животные\n" +
                $"Имя животного - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Вес - {Weigth}\n";
        }
    }
}
