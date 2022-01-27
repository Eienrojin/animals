using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Lion : Animals
    {
        public Lion(string name, int age, double weight, int jumpHeigth) : base(name, age, weight)
        {
            JumpHeigth = jumpHeigth;
        }

        public Lion() { }

        public int JumpHeigth { get; set; }

        public override string ToString()
        {
            return $"Группа - Львы\n" +
                $"Имя животного - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Вес - {Weigth}\n" +
                $"Высота прижка - {JumpHeigth} см\n";
        }
    }
}
