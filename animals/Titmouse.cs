using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Titmouse : Bird
    {
        public Titmouse(string name, int age, double weigth, int flyHeight, double wingspan) : base(name, age, weigth, flyHeight)
        {
            Wingspan = wingspan;
        }

        public Titmouse() { }

        public double Wingspan { get; set; }

        public override string ToString()
        {
            return $"Группа - Синицы\n" +
                $"Имя животного - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Вес - {Weigth}\n" +
                $"Высота полёта - {FlyHeight} метров\n" +
                $"Размах крыльев - {Wingspan} сантиметров\n";
        }
    }
}
