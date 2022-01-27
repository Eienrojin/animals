using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Dolphin : Animals
    {
        public Dolphin(string name, int age, double weigth, int diveDepth) : base(name, age, weigth)
        {
            DiveDepth = diveDepth;
        }

        public Dolphin() { }

        public int DiveDepth { get; set; }

        public override string ToString()
        {
            return $"Группа - Дельфины\n" +
                $"Имя животного - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Вес - {Weigth}\n" +
                $"Глубина погружения - {DiveDepth} метров\n";
        }
    }
}
