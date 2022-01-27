using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Bird : Animals
    {
        public Bird(string name, int age, double weigth, int flyHeight) : base(name, age, weigth)
        {
            FlyHeight = flyHeight;
        }

        public Bird() { }

        public int FlyHeight { get; set; }

        public override string ToString()
        {
            return $"Группа - Птицы\n" +
                $"Имя животного - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Вес - {Weigth}\n" +
                $"Высота полёта - {FlyHeight} метров\n";
        }
    }
}
